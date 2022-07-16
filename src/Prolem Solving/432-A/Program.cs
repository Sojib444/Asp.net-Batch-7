
string[] s=Console.ReadLine().Split(" ");
int a=int.Parse(s[0]);
int b=int.Parse(s[1]);
int[] arr = new int[a];
string[] p = Console.ReadLine().Split(" ");
for(int i = 0; i < a; i++)
{
    arr[i] = int.Parse(p[i]);
}
int sum = 0;
for (int i = 0; i < a; i++)
{
    if (arr[i] + b <= 5)
    {
        sum++;
    }
}
Console.WriteLine(sum/3);