namespace data_structures;

public class BinaryTree
{
    private TreeNode root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int value)
    {
        root = InsertRecursive(root,  value);
        
    }

    private TreeNode InsertRecursive(TreeNode node, int value)
    {
        if (node == null)
        {
            node = new TreeNode(value);
            return node;
        }

        if (value < node.Value)
        {
            node.Left = InsertRecursive(node.Left, value);
        }
        else
        {
            node.Right = InsertRecursive(node.Right, value);
        }
        return node;
    }
    public bool Find(int value)
    {
        return FindRecursive(root, value);
    }
    private bool FindRecursive(TreeNode node, int value)
    {
        if (node == null)
            return false;
        if (node.Value == value)
            return true;
        if (value < node.Value)
            return FindRecursive(node.Left, value);
        return FindRecursive(node.Right, value);
    }

    public int? getMaxValue()
    {
        return GetNax(root);
    }
    public int? GetNax(TreeNode node)
    {
        if (node == null)
        {
            return null;
        }
       
        while (root.Right != null)
        {
            node = node.Right;
        }
        return node.Value;
    }

    public int? GetMinValue()
    {
        return GetMin(root);
    }

    private int? GetMin(TreeNode node)
    {
        if (node == null)
        {
            return null;
        }
        
        while (root.Left != null)
        {
            node = node.Left;
        }
        return node.Value;
    }

    public void Delete(int value)
    {
        root = DeleteRecursive(root,  value);
    }

    private TreeNode DeleteRecursive(TreeNode node, int value)
    {
        if (node == null)
        {
            return null;
        }

        if (value < node.Value)
        {
            node.Left = DeleteRecursive(node.Left, value);
        }

        if (value > node.Value)
        {
            node.Right = DeleteRecursive(node.Right, value);
        }
        else
        {
            //כאשר אין לו בנים אני מחזיר לאבא שלו null 
            if (node.Left == null && node.Right == null)
            {
                return null;
            }
            //כאשר יש לו בן ימני רק
            if (node.Left == null)
            {
                return node.Right;
            }
            //כאשר יש לו בן שמאלי
            if (node.Right == null)
            {
                return node.Left;
            }
            else
            {
                //מוצא את האיבר המינימלי הגדול ממני ומעדכן את הצומת הנוכחית שאותה אני רוצה למחוק
                node.Value = GetMin(node.Right).Value;
                //מסיר את ההצבעה שהייתה לי לצומת שעדכנתי להיות המחליפה שלי
                node.Right = DeleteRecursive(node.Right, node.Value);
                
            }
            
            
        }
        return node;
    }
    //סריקה תוכית של תת עץ השמאלי הדפסה של הצומת וסריקה של תת עץ הימני
    public void InOrder(TreeNode node)
    {
        if (node == null)
        {
            return;
        }
        InOrder(node.Left);
        Console.WriteLine(node.Value + " ");
        InOrder(node.Right);
    }
    //סריקה תכילית הדפסה קודם של השורש ובכך אני יכול לשחזר את העץ ואז סריקה של תת עץ שמאלי ואז תת עץ ימני
    public void PreOrder(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Console.WriteLine(node.Value + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }
//גם בסריקה סופית נוכל לשחזר את העץ כי אני יודע שהשורש נמצא בסוף
    public void PostOrder(TreeNode node)
    {
        if (node == null)
        {
            return;
        }
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.WriteLine(node.Value + " ");
    }
    
}