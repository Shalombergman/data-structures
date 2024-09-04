namespace data_structures;

public class Node<T>
{
    private T _value;
    private Node<T> _next;
    private Node<T> _previous;
    
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
    public Node<T> GetPrevious() => _previous;

    public void SetPrevious(Node<T> previous)
    {
        _previous = previous;
    }

    public Node(T value)
    {
        this._value = value;
        this._next = null;
        this._previous = null;
    }

    public Node(T value, Node<T> next , Node<T> previous)
    {
        this._value = value;
        this._next = next;
        this._previous = previous;
    }
    public bool HasNext() => _next != null;
    public bool HasPrevious() => _previous != null;

    public override string ToString()
    {
        return _value.ToString();
    }
    
    
}