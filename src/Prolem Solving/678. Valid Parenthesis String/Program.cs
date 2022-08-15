


string p = Console.ReadLine();

bool flag = false;

int s = 0;
int e = p.Length - 1;

while(s<e)
{
    if(p[s]=='(' && (p[e]=='*' ||p[e]==')'))
    {
        flag= true;
    }
    else if(p[s] == '*' && (p[e] == ')' || p[e] == '('))
    {
        flag = true;
    }
    s++;
    e--;
    
}

if(flag)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("NO");
}