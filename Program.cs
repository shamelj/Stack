// See https://aka.ms/new-console-template for more information
using MyCollections.Generic;
Console.WriteLine("Hello, World!");
var st = new MyCollections.Generic.Stack<string>();
Console.WriteLine(st.Peak());
AddToStack(st);
st.Print();
Console.WriteLine(st.Peak());
static void AddToStack(MyCollections.Generic.Stack<string> st)
{
    st.Push("1"); st.Push("2"); st.Push("3");
}