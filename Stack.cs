namespace Collections.Generic;
public class Stack<T>
{
    private Node? Head { get; set; }
    public void Print()
    {
        Node? curr = Head;
        while(curr != null)
        {
            Console.WriteLine($"| {curr.Value} |");
            curr = curr.Next;
        }
    }
    private class Node
    {
        internal Node? Next { get; set; }
        internal T Value { get; set; }
        internal Node(T value) => Value = value;
        internal Node(Node? next, T value) : this(value) => Next = next;
    }
}
