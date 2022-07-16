


int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
string[] s = Console.ReadLine().Split(" ");

for(int i=0;i<n;i++)
{
    arr[i] = int.Parse(s[i]);
}
    for (int i = 0; i < n - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < n; j++)
    {
        if (arr[min] < arr[j])
        {
            min = j;
        }
    }
    if (min != i)
    {
        int temp = arr[i];
        arr[i] = arr[min];
        arr[min] = temp;
    }
}
//    for(int i=0;i<n;i++)
//    {
//        cout<<arr[i]<<" ";
//    }
int sum = 0;
for (int i = 1; i < n; i++)
{
    if (arr[0] > arr[i])
    {
        sum += (arr[0] - arr[i]);
    }
}
Console.WriteLine(sum);