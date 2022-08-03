


string s = Console.ReadLine();
string s1 = Console.ReadLine();

string s3 = "";
char c = '0';


for(int i=s.Length-1;i>=0;i--)
{
    if(i>=s1.Length-1)
    {
        if(s[i]=='0' && s1[i]=='0' && c=='0')
        {
            s3 += '0';
        }
        else if((s[i] == '0' && s1[i-1] == '1' )|| (s[i] == '1' && s1[i-1] == '0') && c == '0')
        {
            s3 += '1';
        }
        else if ((s[i] == '0' && s1[i-1] == '1') || (s[i] == '1' && s1[i-1] == '0') && c == '1')
        {
            s3 += '0';
            c = '1';
        }
        else
        {
            s3 += '0';
            c = '1';
        }
    }
    else
    {
        if (s[i] == '0' && c == '0')
        {
            s3 += '0';
        }
        else if (s[i] == '1' && c == '0')
        {
            s3 += '1';
        }
        else if (s[i] == '0'  && c == '1')
        {
            s3 += '1';
            c = '0';
        }
        else
        {
            s3 += '0';
            c = '1';
        }
    }

}
if (c == '1')
{
    s3 += '1';

}


Console.WriteLine(s3);