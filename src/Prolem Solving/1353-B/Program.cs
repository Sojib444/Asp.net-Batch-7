

int t = Convert.ToInt32(Console.ReadLine());
while(t>0)
{
    string[] q = Console.ReadLine().Split(" ");
    int n= int.Parse(q[0]);
    int k= int.Parse(q[1]);
    string[] s = Console.ReadLine().Split(" ");
    string[] p = Console.ReadLine().Split(" ");
    int[] a = new int[n];
    int[] b = new int[n];
    for(int i=0;i<n;i++)
    {
        a[i] = int.Parse(s[i]);
    }
    for (int i = 0; i < n; i++)
    {
        b[i] = int.Parse(p[i]);
    }
    for (int i = 0; i < n; i++)
    {

        int min = i;
        for (int j = i + 1; j < n; j++)
        {
            if (a[min] > a[j])
            {
                min = j;
            }
        }
        if (min != i)
        {
            int temp = a[i];
            a[i] = a[min];
            a[min] = temp;
        }
    }
    for (int i = 0; i < n; i++)
    {

        int max = i;
        for (int j = i + 1; j < n; j++)
        {
            if (b[max] < b[j])
            {
                max = j;
            }
        }
        if (max != i)
        {
            int temp = b[i];
            b[i] = b[max];
            b[max] = temp;
        }
    }

    for (int i = 0; i < k; i++)
    {
        if (a[i] < b[i])
        {
            a[i] = b[i];

        }
    }

    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += a[i];
    }
    Console.WriteLine(sum);
    t--;
}
