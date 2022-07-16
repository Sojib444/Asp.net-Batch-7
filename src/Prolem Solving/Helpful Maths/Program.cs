

using System;
class Program
{
    static void Main()
    {
        string s=Console.ReadLine();
        int sum = 0;
        int[] arr = new int[100];
        for(int i=0;i<s.Length;i++)
        {
            sum++;
            arr[i] = s[i] - 48;
        }


        for (int i = 0; i < sum; i = i + 2)
        {
            int min = i;

            for (int j = i + 2; j < sum; j = j + 2)
            {
                if (arr[min] > arr[j])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

        }
        for (int i = 0; i < sum; i = i + 2)
        {
            Console.Write(arr[i]);
            if (i == sum - 1)
            {
                break;
            }
            Console.Write("+");
        }
    }
}