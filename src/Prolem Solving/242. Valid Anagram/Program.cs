


string s = Console.ReadLine();
string p = Console.ReadLine();
if(s.Length!=p.Length)
{
    Console.WriteLine("NO");
}
int[] arr = new int[25+1];

for(int i=0;i<s.Length;i++)
{
    int d = s[i] - 97;
    arr[d]++;
}
for (int i = 0; i < p.Length; i++)
{
    int d = p[i] - 97;
    arr[d]--;
}
bool flag = true;

for(int i=0;i<arr.Length;i++)
{
    if(arr[i]!=0)
    {
        flag = false;
        break;
    }
}

Console.WriteLine(flag);