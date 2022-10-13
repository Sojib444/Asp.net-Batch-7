// See https://aka.ms/new-console-template for more information

int n = Convert.ToInt32(Console.ReadLine());

int ReverseInt(int n)
{
    int m = n;
    int count = 0;
    while (n != 0)
    {
        n=n>> 1;
        count++;

    }
    int mask = 0;
    while(count!=0)
    {
        mask = (mask << 1) | 1;
        count--;
    }
    if(m==0)
    {
        return 1;
    }
    return ~m & mask;

}

int result = ReverseInt(n);
Console.WriteLine(result);
