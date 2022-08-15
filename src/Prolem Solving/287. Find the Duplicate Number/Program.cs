



using System;

int[] arr = { 1, 2, 3,4, 4};

int[] brr = new Int32[arr.Length];

for(int i=0;i<brr.Length;i++)
{
    brr[arr[i]]++;
}

for(int i=0;i<brr.Length;i++)
{
    if(brr[i]>1)
    {
        Console.WriteLine(i);
        break;
    }
}