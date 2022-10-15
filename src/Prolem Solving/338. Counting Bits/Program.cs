

int n = Convert.ToInt32(Console.ReadLine());


int[] Get(int n)
{
    int[] arr = new int[n + 1];
    int k = 0;
    for(int i=0;i<n+1;i++)
    {
        int count = 0;
        int temp = i;
        while(temp!=0)
        {
            int d = temp & 1;
            if(d == 1)
            {
                count++;
            }
            temp = temp >> 1;
        }
        arr[i] = count;
    }
    return arr;
}
var result = Get(n);

foreach(var item in result)
{
    Console.WriteLine(item);
}