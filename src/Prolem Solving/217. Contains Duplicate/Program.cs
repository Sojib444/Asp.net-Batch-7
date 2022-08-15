


int[] arr = { 1,2,3,1};

HashSet<int> hash = new HashSet<int>();
bool flag = false;
foreach(var item in arr)
{
    if (!hash.Add(item))
    {
        flag = true;
        break;
    }
   
}

if(flag==true)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}