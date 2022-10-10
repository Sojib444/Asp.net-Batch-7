
int n = Convert.ToInt32(Console.ReadLine());


bool flag=true;



while(n!=0)
{
    int d = n & 1;
    n = n >> 1;
    int f = n & 1;
    if (d==f)
    {
        flag = false;
        break;
    }

    
}
Console.WriteLine(flag);
