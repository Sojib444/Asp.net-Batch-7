using System;
class NAme
{
    static void Main()
    {
        string s = Console.ReadLine();
        string p = "";
        
        for(int i=0;i<s.Length;i++)
        {
            if(i==0)
            {
                if (s[0] >= 'a' && s[0] <= 'z')
                {
                    int d = s[i] - 32;
                    char c = Convert.ToChar(d);
                    p = p + c;
                }
                else
                {
                    p = p + s[i];
                }
            }
            else
            {
                p = p + s[i];
            }
        }
        Console.WriteLine(p);

    }
}