

int[] arr = { 1,1};

HashSet<int> list = new HashSet<int>();
List<int> result = new List<int>();

foreach(var item in arr)
{
    list.Add(item);
}

for(int i=1;i<=arr.Length;i++)
{
    if(!list.Contains(i))
    {
        result.Add(i);
    }
}

foreach(var item in result)
{
    Console.WriteLine(item);
}

