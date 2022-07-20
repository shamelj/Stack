namespace MyCollections.Generic;
public class Stack<T> where T : notnull
{
    private Node? Head { get; set; }
    public int Size { get; private set; } = 0;
    public void Print()
    {
        Node? curr = Head;
        while (curr != null)
        {
            Console.WriteLine($"| {curr.Value} |");
            curr = curr.Next;
        }
    }
    public bool IsEmpty() => Head == null;
    public void Push(T element)
    {
        if (IsEmpty())
            Head = new Node(element);
        else
            Head = new Node(Head, element);
        Size++;
    }
    public T Peak()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is Empty");
        return Head.Value;
    }
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is Empty");
        var top = Head.Value;
        Head = Head.Next;
        return top;
    }
    public void Clear()
    {
        Head = null;
        Size = 0;
    }
    private class Node
    {
        internal Node? Next { get; set; }
        internal T Value { get; set; }
        internal Node(T value) => Value = value;
        internal Node(Node? next, T value) : this(value) => Next = next;
    }
}
