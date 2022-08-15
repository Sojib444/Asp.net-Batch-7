



int n = Convert.ToInt32(Console.ReadLine());
string p=Convert.ToString(n);


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
if (flag)
{
    Console.WriteLine("Yes");
}
else
    Console.WriteLine("No");