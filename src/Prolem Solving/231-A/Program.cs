using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int a, b, c;
        int sum = 0;
        while(n>0)
        {
            string[] s = Console.ReadLine().Split(" ");
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);
            if(a+b+c>=2)
            {
                sum++;
            }
            n--;
        }
        Console.WriteLine(sum);

    }
}