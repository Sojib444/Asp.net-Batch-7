using System;
class Name
{
    static void Main()
    {
        string s = Console.ReadLine();
        int up = 0;
        int lo = 0;
        string upper = "";
        string lower = "";
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]>='A' && s[i]<='Z')
            {
                up++;
                int d = s[i] + 32;
                 int f = s[i];
                char c = Convert.ToChar(d);
                char g = Convert.ToChar(f);
                upper = upper + g;
                lower = lower + c;



            }
            else if(s[i]>='a' && s[i]<='z')
            {
                lo++;
                int d = s[i] - 32;
                int f = s[i];
                char c = Convert.ToChar(d);
                char g = Convert.ToChar(f);
                upper = upper + c;
                lower = lower + g;
            }
        }
        
        if(up>lo)
        {
             Console.WriteLine(upper);
        }
        else if(up==lo)
        {
            Console.WriteLine(lower);
        }
        else
        {
             Console.WriteLine(lower);
        }
           
        
       
    }
}