


using System;
class Name
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(" ");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        if (a <= b)
        {
            Console.Write(a+" "); 
            int d = b - a;
            if (d < 2)
            {
                Console.Write(0 + " "); 
            }
            else
            {
                Console.Write(d/2 + " "); 
            }
        }
        if (b < a)
        {
            Console.Write(b + " "); 
            int d = a - b;
            if (d < 2)
            {
                Console.Write(0 + " "); 
            }
            else
            {
                Console.Write(d/2 + " ");
            }
            if (a == b)
            {
                Console.Write(a + " "+0); 
            }
        }
    }
}