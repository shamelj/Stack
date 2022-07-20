namespace Collections.Generic;
public class Stack<T>
{
    private Node? Head { get; set; }
    class Node
    {
        Node? Next { get; set; }
        T Value { get; set; }
        Node(T value) => Value = value;
        Node(Node? next, T value) : this(value) => Next = next;
    }
}
