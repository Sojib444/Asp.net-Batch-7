

using System;

string s = "leetlcode";

HashSet<char> set = new HashSet<char>();
HashSet<char> set1 = new HashSet<char>();

for(int i=0;i<s.Length;i++)
{
    if (!set.Contains(s[i]))
    {
        set.Add(s[i]);
    }
    else
        set1.Add(s[i]);

}

for(int i=0;i<s.Length;i++)
{
    if(!set1.Contains(s[i]))
    {
        Console.WriteLine(i);
        break;
    }
}