// See https://aka.ms/new-console-template for more information

int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for(int j=0;j<n;j++)
    {
        if(j<i)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}


