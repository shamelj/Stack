namespace MyCollections.Generic;
public class Stack<T>
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
    }
    public T Peak()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is Empty");
        return Head.Value;
    }
    private class Node
    {
        internal Node? Next { get; set; }
        internal T Value { get; set; }
        internal Node(T value) => Value = value;
        internal Node(Node? next, T value) : this(value) => Next = next;
    }
}
