// See https://aka.ms/new-console-template for more information


int n = Convert.ToInt32(Console.ReadLine());

int count = 0;
while(n!=0)
{
    int d = n & 1;
    if(d==1)
    {
        count++;
    }
    n = n >> 1;
}
Console.WriteLine(count);