using System;
class Proram
{
    static void Main()
    {
string[] input=Console.ReadLine().Split(" ");

int n = int.Parse(input[0]);
int t = int.Parse(input[1]);
int sum = n;

while(t>0)
{
    int d = sum % 10;
    if(d>0)
    {
        sum--;

    }
    else if(d==0)
    {
        sum = sum / 10;
    }
    t--;
}
Console.WriteLine(sum);
    }

}
