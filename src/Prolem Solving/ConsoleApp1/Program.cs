using System;
class Program
{
    static void Main()
    {

        string[] bear = Console.ReadLine().Split(" ");
        int bw = int.Parse(bear[0]);
        int biw = int.Parse(bear[1].Trim());
        

        int a = bw, b = biw;
        for(int i=1;i<100;i++)
        {
            ////Hi this is sojib .......
            /////This is Islamic University 
            a *= 3;
            b *= 2;
            if(a>b)
            {
                Console.WriteLine(i);
                break;
            }
        }

    }
}