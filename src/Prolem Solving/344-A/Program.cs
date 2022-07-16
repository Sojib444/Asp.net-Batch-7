

using System;
class Name
{
    static void Main()
    {


        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 1;
        string[] ff = new string[1];
        for(int i=0;i<n;i++)
        {
            if(i==0)
            {
                string sre = Console.ReadLine();
                ff[0] = sre;
            }
            else
            {
                string sre = Console.ReadLine();
                if(sre!=ff[0])
                {
                    sum++;
                }
                ff[0] = sre;
            }
            
        }
        Console.WriteLine(sum);
    }
}
