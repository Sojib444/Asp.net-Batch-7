// See https://aka.ms/new-console-template for more information


string[] s = Console.ReadLine().Split(" ");
int[] arr = new int[s.Length];
for(int i=0;i<s.Length;i++)
{
    arr[i] = int.Parse(s[i]);
}

int result = 0;
int CountFrequency(int[] n)
{
    foreach (var item in n)
    {
        result ^= item;
            
    }
    return result;
}

var ans = CountFrequency(arr);
Console.WriteLine(ans);
