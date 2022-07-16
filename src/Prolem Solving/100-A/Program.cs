using System;
class NAme
{
    static void Main()
    {
        string s = Console.ReadLine();
        long sum = 0;
        for(int i=0;i<s.Length;i++)
        {
            int d = s[i] - 48;
            if(d==4 || d==7)
            {
                sum++;
            }
        }
        if(sum==4 || sum==7)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}