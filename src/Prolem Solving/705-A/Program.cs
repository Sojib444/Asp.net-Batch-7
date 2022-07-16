

using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            if(i%2 !=0)
            {
                Console.Write("I hate ");
            }
            else
            {
                Console.Write("I love ");
            }
            if(i==n)
            {
                Console.Write("it");
            }
            else
            {
                Console.Write("that ");
            }
        }
    }
}