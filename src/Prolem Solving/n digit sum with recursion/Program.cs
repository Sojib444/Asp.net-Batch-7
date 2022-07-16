using System;

namespace n_digit_sum_with_recursion
{
    class Program
    {

        public int Sum(int n)
        {
            if (n == 1)
                return 1;
            return n + Sum(n - 1);
        }sdsd
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int Sum=new int
            Console.WriteLine(Sum(n));

        }
    }
}
