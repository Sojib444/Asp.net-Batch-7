

bool composite(int n)
{
    if (n <= 2)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return true;
            break;
        }

    }
    return false;
}


   int n=Convert.ToInt32(Console.ReadLine());
    
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i + j == n)
            {
                if (composite(i) && composite(j))
                {
                    Console.WriteLine(i+" "+j);
                    sum++;
                    break;
                }
            }
        }
        if (sum > 0)
        {
            break;
        }
    }
 

