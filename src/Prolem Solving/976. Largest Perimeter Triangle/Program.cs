// See https://aka.ms/new-console-template for more information


string[] s = Console.ReadLine().Split(" ");

int[] arr = new int[s.Length];

for(int i=0;i<s.Length;i++)
{
    arr[i] = int.Parse(s[i]);
}

Array.Sort(arr);

int count = 0;
for(int i=arr.Length-3;i>=0;i--)
{
    if (arr[i] + arr[i + 1] > arr[i+2])
    {
        count=arr[i] + arr[i + 1] + arr[i + 2];
        break;

    }
}

Console.WriteLine(count);