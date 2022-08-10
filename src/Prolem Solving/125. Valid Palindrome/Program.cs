


string s = Console.ReadLine();
string p = "";

for(int i=0;i<s.Length;i++)
{
    if(s[i]>='A' && s[i]<='Z')
    {
        char c = Convert.ToChar(s[i] +32);
        p += c;
    }
    else if (s[i] >= 'a' && s[i] <= 'z')
    {
        p += s[i];
    }
}

int st = 0;
int ed = p.Length - 1;
bool flag = true;
while (st < ed)
{
    if (p[st++] != p[ed--])
    {
        flag = false;
        break;
    }
}
Console.WriteLine(p);
if(flag)
{
    Console.WriteLine("Yes");
}
else
    Console.WriteLine("No");