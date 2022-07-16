using System;
class Name
{
    static void Main()
    {
        string s = Console.ReadLine();
        string p = Console.ReadLine();
        string q ="";
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]==p[i])
            {
                q = q + '0';
            }
            else
            {
                q=q+ '1';
            }
        }
        Console.WriteLine(q);
    }
}
