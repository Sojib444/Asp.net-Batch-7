

string[] s = Console.ReadLine().Split(',');

int[] arr = new int[s.Length];


for(int i=0;i<s.Length;i++)
{
    arr[i] = int.Parse(s[i]);
}
int[] brr = new int[500];
bool flag = true;
for(int i=0;i<arr.Length;i++)
{
    brr[arr[i]]++;
}

for(int i=0;i<brr.Length;i++)
{
    int d = brr[i] & 1;
    if(d==1)
    {
        flag = false;
        break;
    }
}

Console.WriteLine(flag);