// See https://aka.ms/new-console-template for more information

int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int d = 65 + i + j;
        char c=Convert.ToChar(d);
        Console.Write(c+" ");
    }
    Console.WriteLine();
}


