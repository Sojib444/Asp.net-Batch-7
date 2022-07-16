using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s = Console.ReadLine().Split(" ");
        int[] arr=new int[n];
        int sum = 0;
        for(int i=0;i<n;i++)
        {
            arr[i] = int.Parse(s[i]);
            sum += arr[i];

        }
        if(sum>0)
        {
            Console.WriteLine("HARD");
            
        }
        else
        {
            Console.WriteLine("EASY");

        }
    }
}