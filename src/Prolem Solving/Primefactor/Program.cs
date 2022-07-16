

int n = Convert.ToInt32(Console.ReadLine());
int limit =Convert.ToInt32(Math.Sqrt(n));
List<int> factor=new List<int>();
for (int i = 2; i <= limit; i++)
{
    while (n % i == 0)
    {
        factor.Add(i);
        n /= i;

    }
}
for (int i = 0; i < factor.Count; i++)
{
    Console.WriteLine(factor[i]+" ");
}
