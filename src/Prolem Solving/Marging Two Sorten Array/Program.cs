





int[] arr = new int[5] {2,3,6,11,48};
int[] arr2=new int[5] {1,3,7,9,10};
int[] arr3 = new int[10];

int i = 0;
int j = 0;
int k = 0;
while(i<5 && j<5)
{
    
    if(arr[i]>=arr2[j])
    {
        arr3[k++] = arr2[j++];
    }
    else
    {
        arr3[k++] = arr[i++];
    }
}

for(;i<5;i++)
{
    arr3[k++] = arr[i];
}
for (; j < 5; j++)
{
    arr3[k++] = arr[j];
}

foreach (int item in arr3)
{
    Console.Write(item+" ");
}

