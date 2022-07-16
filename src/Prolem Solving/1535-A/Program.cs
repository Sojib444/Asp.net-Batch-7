
int n = Convert.ToInt32(Console.ReadLine());
while(n>0)
{
    string[] s = Console.ReadLine().Split(" ");
    int a=int.Parse(s[0]);
    int b=int.Parse(s[1]);
    int c=int.Parse(s[2]);
    int d = int.Parse(s[3]);
    int fmax = Math.Max(a, b);
    int fmin = Math.Min(a, b);
    int smax = Math.Max(c, d);
    int smin = Math.Min(c, d);

    if (fmax < smin || smax < fmin)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}