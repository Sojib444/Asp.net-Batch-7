

int n = Convert.ToInt32(Console.ReadLine());

for (int i = n; i>0; i--)
{
    for (int j = i; j <=n; j++)
    {
        int d = 65 + j;
        char c = Convert.ToChar(d);
        Console.Write(c + " ");
    }
    Console.WriteLine();
}
