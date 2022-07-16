using System;
class Name
{
    static void Main()
    {
        int n = Convert. ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                sum -= i;
            }
            else
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}