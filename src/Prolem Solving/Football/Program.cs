using System;
class Program
{
    static void Main()
    {
        string p = Console.ReadLine();
        int sum = 1;
        for (int i = 0; i < p.Length; i++)
        {

            for (int j = i + 1; j < p.Length; j++)
            {
                if (p[i] == p[j])
                {
                    sum++;
                }
                else
                {
                    break;
                }

            }

            if (sum >= 7)
            {
                Console.WriteLine("YES");
                break;
            }
            else if (sum < 7 && i == p.Length - 1)
            {

                Console.WriteLine("NO"); 
                break;
            }
            else
            {
                sum = 1;
            }



        }

    }
}
