

using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(" ");
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if(a%b==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(b - (a % b));
            }
        }
    }
}
