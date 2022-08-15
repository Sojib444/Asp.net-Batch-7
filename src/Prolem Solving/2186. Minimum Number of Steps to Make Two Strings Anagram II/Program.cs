



using System;
string s = Console.ReadLine();
string p = Console.ReadLine();
Console.WriteLine(p.Length);

int[] arr = new int[26];
int sum = 0;

for (int i = 0; i < s.Length; i++)
{
    int d = s[i] - 97;
    arr[d]++;
}
for (int i = 0; i < p.Length; i++)
{
    int d = p[i] - 97;
    if (arr[d] > 0)
    {
        arr[d]--;
    }
    else
        sum++;
}


Console.WriteLine(sum);


