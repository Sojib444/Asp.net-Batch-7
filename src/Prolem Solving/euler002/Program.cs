

int n = 1000;
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
for(int i=2;i<n;i++)
{
    int sum = list[i-1] + list[i-2];
    list.Add(sum);
}

for (int i = 0; i < list.Count; i++)
{
    Console.Write(list[i]+" ");
}