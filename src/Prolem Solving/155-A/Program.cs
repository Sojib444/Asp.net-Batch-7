

using System;
class Name
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr=new int[n];
        string[] s = Console.ReadLine().Split(" ");
        for(int i=0;i<n;i++)
        {
            arr[i] = int.Parse(s[i]);
        }
        int count = 0;

        for (int i = 1; i < n; i++)
        {


            if (arr[i] < arr[i - 1])
            {
                int sum = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        sum++;
                    }
                }
                if (sum == i)
                {
                    count++;
                    sum = 0;
                }
               
            }

            if (arr[i] > arr[i - 1])
            {
                int sum = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        sum++;
                    }
                }
                if (sum == i)
                {
                    count++;
                    sum = 0;
                }
               
            }




        }
       Console.WriteLine(count);

    }
}
