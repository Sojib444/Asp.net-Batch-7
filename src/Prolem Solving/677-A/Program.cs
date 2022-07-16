using System;
class Name
{
    static  void Main()
    {
        string[] s = Console.ReadLine().Split(" ");
        int n = int.Parse(s[0]);
        int h = int.Parse(s[1]);
        string[] p = Console.ReadLine().Split(" ");
        int[] arr = new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i] = int.Parse(p[i]);
        }
        int sum = 0;
        for(int i=0;i<n;i++)
        {
            if(arr[i]>h)
            {
                sum = sum + 2;
            }
            else
            {
                sum++;
            }
        }
        Console.WriteLine(sum);

    }
}
