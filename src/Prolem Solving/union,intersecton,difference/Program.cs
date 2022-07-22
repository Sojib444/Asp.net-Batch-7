


int[] arr = new int[] { 1,2, 3, 4, 5, 6 };
int[] arr1 = new int[] {2 ,3, 5, 8, 9 };


int[] union(int[] arr,int[] arr2)
{
    int[] arr3 = new int[arr.Length + arr2.Length];
    int i = 0;
    int j = 0;
    int k = 0;
    while (i<arr.Length && j<arr2.Length)
    {
        if (arr[i] > arr2[j])
            arr3[k++] = arr2[j++];
        else if (arr[i] < arr2[j])
            arr3[k++] = arr[i++];
        else
        {
            arr3[k++]=arr2[j++];
            i++;
        }

    }
    for (; i < arr.Length; i++)
    {
        arr3[k++] = arr[i];
    }
    for (; j < arr2.Length; j++)
    {
        arr3[k++] = arr2[j];
    }
    return arr3;

}

int[] result=union(arr, arr1);
//foreach(int i in result)
//{
//    Console.WriteLine(i);
//}

int[] intersectionn(int[] arr, int[] arr2)
{
    int[] arr3 = new int[arr.Length + arr2.Length];
    int i = 0;
    int j = 0;
    int k = 0;
    while (i < arr.Length && j < arr2.Length)
    {
        if (arr[i] > arr2[j])
            j++;
        else if (arr[i] < arr2[j])
            i++;
        else
        {
            arr3[k++] = arr2[j++];
            i++;
        }

    }
    return arr3;
}

int[] result1 = intersectionn(arr, arr1);
//foreach (int i in result1)
//{
//    Console.Write(i + " ");
//}


int[] Difference(int[] arr, int[] arr2)
{
    int[] arr3 = new int[arr.Length + arr2.Length];
    int i = 0;
    int j = 0;
    int k = 0;
    while (i < arr.Length )
    {
        if (arr[i] != arr2[j])
        {
            arr3[k++] = arr[i++];
        }
        else
        {
            i++;
            j++;
        }

    }

    for(;i<arr.Length;i++)
    {
        arr3[k++] = arr[i];
    }
    return arr3;
}

int[] result3 = Difference(arr, arr1);
foreach (int i in result3)
{
    Console.Write(i + " ");
}