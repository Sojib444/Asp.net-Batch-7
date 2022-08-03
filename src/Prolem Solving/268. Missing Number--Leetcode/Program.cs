

int[] arr = {1};
Array.Sort(arr);


int Missing_Array(int[] arr)
{
    int d=arr.Length;
    int n=d*(d+1)/2;
    int sum = 0;
    for(int i=0;i<arr.Length;i++)
    {
        sum += arr[i];
    }
    return n - sum;

}

int result=Missing_Array(arr);
Console.WriteLine(result);