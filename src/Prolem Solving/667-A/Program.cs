

using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
       
        while(n>0)
        {
            string[] s = Console.ReadLine().Split(" ");
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if(a+1<b)
            {
                sum++;
            }
            n--;
        }
        Console.WriteLine(sum);
       
    }
}