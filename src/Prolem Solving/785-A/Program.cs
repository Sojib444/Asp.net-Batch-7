using System;
class NAme
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s=new string[n];
        for(int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();
        }
        int sum = 0;
        for(int j = 0; j < n;j++)
        {
            if (s[j] == "Tetrahedron")
            {
                sum = sum + 4;

            }
            else if (s[j] == "Cube")
            {
                sum = sum + 6;

            }
            else if (s[j] == "Octahedron")
            {
                sum = sum + 8;

            }
            else if (s[j] == "Dodecahedron")
            {
                sum = sum + 12;

            }
            else if (s[j] == "Icosahedron")
            {
                sum = sum + 20;

            }
        }
        Console.WriteLine(sum);
    }
}