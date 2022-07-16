using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        char[] arr = new char[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToChar(Console.Read());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    sum++;
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine(sum);

    }
}