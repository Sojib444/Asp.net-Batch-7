

using System;
class Name
{
   static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int max = int.MinValue;
        int sum = 0;
        while(n>0)
        {
            string[] tram = Console.ReadLine().Split();
            int ai = int.Parse(tram[0]);
            int bi = int.Parse(tram[1]);
            sum = sum - ai;
            sum = sum + bi;
            if(sum>max)
            {
                max = sum;
            }

            n--;
        }
        Console.WriteLine(max);
    }
}
