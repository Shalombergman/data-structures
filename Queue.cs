namespace data_structures;

public class Queue<T>
{
    private Node<T> _head;
    private Node<T> _tail;

    public Queue()
    {
        _head = null;
        _tail = null;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }

    public void Enqueue(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (IsEmpty())
        {
            _head = newNode;
            _tail = newNode;
        }
        _tail.SetNext(newNode);
        _tail = newNode;
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            return default;
        }
        T temp = _head.GetValue();
        _head = _head.GetNext();
        return temp;
    }

    public T Peek()
    {
        return _head.GetValue();
    }
}