﻿


using System;
class NAme
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr=new int[n];
        int max = int.MinValue;
        int min=int.MaxValue;
        string[] s =Console.ReadLine().Split(" ");
        for(int i = 0;i<n;i++)
        {
            arr[i] = int.Parse(s[i]);
        }
        for(int i=0;i<n;i++)
        {
            if(arr[i]==max)
            {
                while(i>0)
                {
                    int temp = arr[i];
                     arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
                break;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(min);
        for(int i=0;i<n;i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
