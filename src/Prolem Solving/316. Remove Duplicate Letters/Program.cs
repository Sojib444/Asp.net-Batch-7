


string s = Console.ReadLine();
char[] ch=new char[123];

for(int i=0;i<s.Length;i++)
{
    ch[s[i]]++;
}

string p = "";
for(int i=97;i<ch.Length;i++)
{
    if(ch[i]!=0)
    {
        p += Convert.ToChar(i);
    }
}