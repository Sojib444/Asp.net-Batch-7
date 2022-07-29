


int[] arr = { 1, 2, 4, 5, 6, 7, 8, 9 };
int target = 2;
int L = 0;
int R = arr.Length - 1;
int index=-1;

while (L <= R)
{
    int mid = L + (R - L) / 2;
    if (arr[mid] == target)
    {
        index = mid;
    }
    if (arr[mid] > target)
    {
        R = mid - 1;
    }
    else
        L = mid+1;


}
Console.WriteLine(index);


