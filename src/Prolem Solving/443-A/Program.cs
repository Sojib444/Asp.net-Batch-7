using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] p = new int[n];
        int[] q = new int[n];
        for(int i=0; i<n; i++)
        {
            string[] s = Console.ReadLine().Split(" ");
            p[i] = int.Parse(s[0]);
            q[i] = int.Parse(s[1]);
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (p[i] == q[j])
                {
                    sum++;
                }
            }
        }
        Console.WriteLine(sum);
    }
}