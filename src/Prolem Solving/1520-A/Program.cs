


int t = Convert.ToInt32(Console.ReadLine());
    while(t>0)
{
    int n = Convert.ToInt32(Console.ReadLine());
    string s = Console.ReadLine();
    string p = string.Empty;
    bool sum = true;
    for (int i = 0; i < n; i++)
    {
        if (i == 0)
        {
            char c = Convert.ToChar(s[0]);
            p += c;
        }
        else
        {
            if (s[i] != s[i - 1])
            {
                p = p + s[i];

            }

        }

    }
    for (int i = 0; i < p.Length; i++)
    {
        for (int j = i + 1; j < p.Length; j++)
        {
            if (p[i] == p[j])
            {
                sum = false;
            }
        }

    }
    if (sum)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}


