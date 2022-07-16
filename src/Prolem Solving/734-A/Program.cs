using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int a = 0;
        int b = 0;
        for (int i = 0; i < s.Length; i++)
        {

            if (s[i] == 'A')
            {
                a++;
            }
            else
            {
                b++;
            }
        }
        if (a > b)
        {
            Console.WriteLine( "Anton");
        }
        else if (b > a)
        {
            Console.WriteLine("Danik");
        }
        else
        {
             Console.WriteLine("Friendship");
        }

    }
}

