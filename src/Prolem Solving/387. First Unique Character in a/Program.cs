

using System;
string s = "lettcode";

int[] arr = new int[27];


for(int i=0;i<s.Length;i++)
{
    int d = s[i] - 97;
    arr[d]++;
}

for(int i=0;i<s.Length;i++)
{
    int d = s[i] - 97;
    if(arr[d]==1)
    {
        Console.WriteLine(i);
        break;
    }
}
