using System;
class Name
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int n = int.Parse(s[0]);
        int m = int.Parse(s[1]);
        int d = n * m;
        int f = d / 2;
        Console.WriteLine(f);
    
    }
}
