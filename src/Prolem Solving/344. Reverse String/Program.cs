using System;


char[] arr = { '2', '3' };
int s = 0;
int e = arr.Length - 1;

while(s<e)
{
    char a=arr[s];
    arr[s] = arr[e];
    arr[e] = a;
    s++;
    e--;
}
Console.WriteLine(arr);