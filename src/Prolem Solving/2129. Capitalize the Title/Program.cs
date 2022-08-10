



string sojib=Console.ReadLine();
string[] s = sojib.Split(" ");


string q;
for(int i=0;i<s.Length;i++)
{
    string p=s[i];
    p.ToLower();
    
    if(p.Length>2)
    {
        for(int j=0;j<p.Length;j++)
        {
            if(p[0]>96)
            {
                char c= Convert.ToChar(p[0] - 32);
                 
            }
        }
    }
}