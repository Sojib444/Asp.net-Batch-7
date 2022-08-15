
using System;


string s = "abbaca";
s.Append('t');
s.

Stack<char> stack = new Stack<char>();

for(int i=0;i<s.Length;i++)
{
    stack.Push(s[i]);
}

Console.WriteLine(stack.Pop());


