

/*int[,] matrix = new int[5, 5];

for (int i = 0; i < 5; i++)
{
    string line = Console.ReadLine();
    string[] parts = line.Split(' ');

    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = int.Parse(parts[j].Trim());
    }
}*/

string[] s = Console.ReadLine().Split(" ");
int[] arr = new int[3];
for(int i=0;i<3;i++)
{
    arr[i]=int.Parse(s[i]);
}

for (int i = 0; i < 3 - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < 3; j++)
    {
        if (arr[min] > arr[j])
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

int d = arr[2] - arr[1];
int f = arr[1] - arr[0];
Console.WriteLine(d+f);