

using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int d = n / 5;
        if (n % 5 > 0)
        {
            Console.WriteLine(d + 1);
        }
        else
        {
            Console.WriteLine(d);
        }
    }
}
