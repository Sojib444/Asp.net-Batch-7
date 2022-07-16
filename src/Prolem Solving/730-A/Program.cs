

int t = Convert.ToInt32(Console.ReadLine());
int misika = 0;
int chery = 0;

while (t>0)
{
    string[] s = Console.ReadLine().Split(" ");
    int m = int.Parse(s[0]);
    int c = int.Parse(s[1]);
    if (m > c)
    {
        misika++;
    }

    else
    {
        chery++;
    }
    if (misika > chery)
    {
        Console.WriteLine("Mishka");
    }
    else if (misika < chery)
    {
        Console.WriteLine("Chris"); 
    }
    else
    {
        Console.WriteLine("Friendship is magic!^^"); 
    }
}
