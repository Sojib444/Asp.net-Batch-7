

using System;
string s = Console.ReadLine();
string p = Console.ReadLine();

int[] arr =new int[26];

for(int i=0;i<s.Length;i++)
{
    int d = s[i] - 97;
    arr[d]++;
}
for (int i = 0; i < p.Length; i++)
{
    int d = s[i] - 97;
    if (arr[d] > 0)
    {
        arr[d]++;
    }
    else
        arr[d]--;
}

int sum = 0;
for(int i=0;i<arr.Length;i++)
{
    sum += arr[i];
}

Console.WriteLine(sum);


