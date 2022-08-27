


int[,] arr = new Int32[3, 3] { { 1, 2, 3 }, { 2, 3, 2 }, { 3,4,5} };

int sum = 0;
int f = arr.GetLength(0);
for(int i=0; i<f;i++)
{
    sum += arr[i,i];
    arr[i,i] = 0;
    sum+=arr[i,f-1-i];
}

Console.WriteLine(sum);


