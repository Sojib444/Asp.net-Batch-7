

int n = Convert.ToInt32(Console.ReadLine());
int total = n;
int line = 0;
for (int i = 1; i <= n; i++)
{
    int sum = 0;
    for (int j = 1; j <= i; j++)
    {
        sum += j;
    }
    total -= sum;
    if (total >=0)
    {
        line++;
    }
    else
    {
        break;
    }

}
Console.WriteLine(line);
