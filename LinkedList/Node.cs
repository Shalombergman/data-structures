namespace data_structures.LinkedList;

public class Node<T>
{
    private T _value;
    private Node<T> _next;
    
    public T GetValue() => _value;

    public void SetValue(T value)
    {
        _value = value;
    }
    public Node<T> GetNext() => _next;

    public void SetNext(Node<T> next)
    {
        _next = next;
    }

    public Node(T value)
    {
        this._value = value;
        this._next = null;
    }

    public Node(T value, Node<T> next)
    {
        this._value = value;
        this._next = next;
    }
    public bool HasNext() => _next != null;

    public override string ToString()
    {
        return _value.ToString();
    }
    
    
}