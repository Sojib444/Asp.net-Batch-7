using System;
class program
{
    static void Main()
    {
        string s = Console.ReadLine();
        for(int i=0;i<s.Length;i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'y' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U' || s[i] == 'Y')
            {
                continue;
            }
            else if(s[i] >= 'A' && s[i] <= 'Z')
            {
                char c = s[i];
                int d = Convert.ToInt32(c);
                int g = d + 32;
                char f = Convert.ToChar(g);
                Console.Write('.'+f);
            }
            else if (s[i] >= 'a' && s[i] <= 'z')
            {
               
                Console.Write('.' + s[i]);
            }
        }
        
        
        
    }
}