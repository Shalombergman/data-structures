namespace data_structures.LinkedList;

public class LinkedList
{
    private Node _head;

    public LinkedList()
    {
        
    }

    public LinkedList(int value)
    {
        this._head.Value = value;
    }
    public void Add(int value)
    {
        if (this._head == null)
        {
            this._head = new Node(value);
            this._head.Value = value;
            this._head.Next = null;
        }
        else
        {
            Node newNode = new Node(value);
            Node current  = this._head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
   
    
    // Method to remove the first value
    public void RemoveValue(int data)
    {
        if (_head == null)
        {
            return;
        }
        var currentNode = _head;
        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
        }
        currentNode.Next = null;
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