// See https://aka.ms/new-console-template for more information


int n = Convert.ToInt32(Console.ReadLine());

int ReverseInt(int n)
{
    int ans = 0;
    while(n!=0)
    {
        int d = n % 10;
        if (ans > (int.MaxValue / 10) || ans < (int.MinValue / 10))
            return 0;
        ans = (ans * 10) + d;
        n = n / 10;
    }
    return ans;
}

int result=ReverseInt(321);
Console.WriteLine(result);