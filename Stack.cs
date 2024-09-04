namespace data_structures.LinkedList;

public class Stack<T>
{
    private Node<T> _head;
    private int _count;

    public Stack()
    {
        _head = null;
        _count = 0;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }

    public void Push(T value)
    {
        
        Node<T> newNode = new Node<T>(value);
        newNode.SetNext(_head.GetNext());
        _head = newNode;
        _count++;
        
    }

    public T pop()
    {
        T temp = _head.GetNext().GetValue();
        _head = _head.GetNext();
        _count--;
        return temp;
        
    }

    public T Peek()
    {
        return _head.GetValue();
    }

    public int Count()
    {
        return _count;
    }
}