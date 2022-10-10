// See https://aka.ms/new-console-template for more information
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int n = x ^ y;
int count = 0;
while (n != 0)
{
    int d = n & 1;
    if (d == 1)
    {
        count++;
    }
    n = n >> 1;
}
Console.WriteLine(count);
