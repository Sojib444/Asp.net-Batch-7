

int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };

int[] brr = new int[arr.Length+1];

List<int> list = new List<int>();

for(int i = 0; i <arr.Length; i++)
{
    brr[arr[i]]++;
}


for(int i=1;i<brr.Length;i++)
{
    if (brr[i] > 1)
        list.Add(i);

}


foreach(var item in list)
{
    Console.WriteLine(item);
}