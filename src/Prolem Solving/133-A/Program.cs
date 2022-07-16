using System;
class NAme

{
    static void Main()
    {
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
           

            if (s[i] == 'H' || s[i] == 'Q' || s[i] == '9')
            {
                Console.WriteLine("YES");
                break;
            }
            else if (i == s.Length - 1)
            {
                Console.WriteLine("NO");
            }


        }

    }
}