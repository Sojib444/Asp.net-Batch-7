using System;
class Name
{
    static void Main()
    {
        string s = Console.ReadLine();
        string p = Console.ReadLine();
        string q = "";
        for(int i=s.Length-1;i>=0;i--)
        {
            int d = s[i];
            char c = Convert.ToChar(d);
            
            q = q + c;
            
        }
        
        if(p==q)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }


    }
}