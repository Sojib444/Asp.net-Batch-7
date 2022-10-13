// See https://aka.ms/new-console-template for more information

int n = Convert.ToInt32(Console.ReadLine());

bool ReverseInt(int n)
{

    int count = 0;
    while (n != 0)
    {
        int d = n & 1;
        if(d==1)
        {
            count++;
        }
        n = n >> 1;
    }
    if(count==1)
    {
        return true;
    }
    else
    {
        return false;
    }

}

bool result = ReverseInt(n);
Console.WriteLine(result);
