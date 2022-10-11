// See https://aka.ms/new-console-template for more information

int n = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());


int count = 0;
while (p != 0 || n!=0)
{
    int d = p & 1;
    int f = n & 1;
    Console.WriteLine(d);
    Console.WriteLine(f);
    if(d!=f)
    {
        count++;
    }
    n=n >> 1;
    p = p >> 1;
}
Console.WriteLine(count);
