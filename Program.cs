// See https://aka.ms/new-console-template for more information
using MyCollections.Generic;
Console.WriteLine("Hello, World!");
var st = new MyCollections.Generic.Stack<int>();
AddToStack(st);
st.Print();
Console.WriteLine($"peak = {st.Peak()}");
st.Clear();
Console.WriteLine("after clearing and adding -1, -2");
st.Push(-1);
st.Push(-2);
st.Print();
st.Pop();
Console.WriteLine("after pop:");
st.Print();
static void AddToStack(MyCollections.Generic.Stack<int> st)
{
    for (int i = 0; i < 10; i++)
        st.Push(i);
}