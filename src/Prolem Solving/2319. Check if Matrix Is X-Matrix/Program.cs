

int[,] arr = new Int32[,] { {1,2},{ 0, 3 } };


bool flag = true;

for(int i=0; i<arr.GetLength(0);i++)
{
    int f = arr.GetLength(0) - 1 - i;
    for (int j=0;j<arr.GetLength(0);j++)
    {
        if((i==j && arr[i,j]==0))
        {
            flag = false;
        }
        else if(j==f && arr[i,j]==0)
        {
            flag = false;
        }
        else if(i != j && j != f && arr[i,j]!=0)
        {
            flag = false;
            break;
        }

    }

    if(flag==false)
    {
        break;
    }
}


Console.WriteLine(flag);
