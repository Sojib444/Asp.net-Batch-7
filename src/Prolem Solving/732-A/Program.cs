
using System;
class NAme
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(" ");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        for (int i = 1; i < 1000; i++)
        {

            int d = a * i;
            if (d % 10 == b || d % 10 == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
