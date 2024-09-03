namespace data_structures.LinkedList;

public class Node
{
    private Node _next;

    public Node Next
    {
        get { return this._next; }   
        set { this._next = Next; }  
    }

    private int _value;
    public int Value
    {
        get
        {
            return this._value;
        }
        set
        {
            this._value = Value;
        }

    }

    public Node(int value)
    {
        this._next = null;
        this._value = value;
    }
    
    
}