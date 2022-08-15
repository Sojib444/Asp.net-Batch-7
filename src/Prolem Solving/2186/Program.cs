

using System;
string s = "cotxazilut";
string p = "nahrrmcchxwrieqqdwdpneitkxgnt";
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


for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
    sum += arr[i];
}

Console.WriteLine(sum);


