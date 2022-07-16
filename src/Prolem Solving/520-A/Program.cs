string s = "hello programmer";
//char[] s = str.ToCharArray();

for(int i=0;i<s.Length; i++)
{
    if(s[i]>='A' && s[i]<='Z')
    {
        int d = s[i] + 32;
        char c = Convert.ToChar(d);
        
    }
}

/*for (int i = 0; i < s.Length; i++)
{
    for (int j = i; j < s.Length; j++)
    {
        if (s[i] > s[j])
        {
            (s[i], s[j]) = (s[j], s[i]);
        }
    }
}*/

/*str = new string(s);*/
Console.WriteLine(str);