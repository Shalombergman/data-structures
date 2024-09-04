namespace data_structures.LinkedList;

public class LinkedList
{
    private Node<int> _head;

    public LinkedList()
    {
        
    }

    public LinkedList(int value)
    {
        this._head.SetValue(value);
    }
    //Add NewNode
    public void Add(int value)
    {
        if (this._head == null)
        {
            this._head = new Node<int>(value);
            this._head.SetValue(value); 
            this._head.SetNext(null); 
        }
        else
        {
            Node<int> newNode = new Node<int>(value);
            Node<int> current  = this._head;
            while (current.HasNext())
            {
                current = current.GetNext();
            }
            current.SetNext(newNode);
        }
    }
   
    
    // Method to remove the first value
    public void RemoveValue(int data)
    {
        if (_head == null)
        {
            return;
        }

        if (_head.GetValue() == data)
        {
            _head= _head.GetNext();
        }
        Node<int> currentNode = _head;
        while (currentNode.HasNext())
        {
            if (currentNode.GetNext().GetValue() == data )
            {
                currentNode = currentNode.GetNext().GetNext();
                return;
            }
            currentNode = currentNode.GetNext();
        }
        
    }

    public String Display()
    {
        string result = "";
        if(_head == null)
        {
            
            return "NULL";
        }
        var currentNode = _head;
        while (currentNode.HasNext())
        {
            result += currentNode.GetValue().ToString() + "->";
            currentNode = currentNode.GetNext();
        }

        if (currentNode.GetValue() != null)
        {
            result += currentNode.GetValue().ToString();
        }
        return result;
        
       
    }
    // Method to remove all the values from the list
    public void RemoveAllValues(int data)
    {

    }

    // Method to remove the value in an index
    public void RemoveIndex(int data)
    {

    }

    
}