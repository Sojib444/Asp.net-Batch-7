


using System;
class Name
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(" ");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= b; j++)
            {
                if (i % 2 == 0)
                {
                    if ((i / 2) % 2 != 0 && j == b)
                    {
                        Console.Write("#");
                    }
                    else if ((i / 2) % 2 == 0 && j == 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("." );
                    }


                }
                else
                {
                    Console.Write("#" );
                }
            }
            Console.WriteLine();
            
        }

    }
}