
using System;
class Program
{
    static void Main()
    {
        int k=Convert.ToInt32(Console.ReadLine());
        int n=Convert.ToInt32(Console.ReadLine());
        int w=Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i=1;i<=w;i++)
        {
            sum += i;
        }
        int d = (sum + k) - n;
        if(d<0)
        {
            Console.WriteLine(0);
        }
        else

        {
            Console.WriteLine(d);
        }
    }
}