// See https://aka.ms/new-console-template for more information


int n = Convert.ToInt32(Console.ReadLine());

int d = 0;
for (int i = 0; i < n; i++)
{
    for (int j = i; j>0; j--)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}

