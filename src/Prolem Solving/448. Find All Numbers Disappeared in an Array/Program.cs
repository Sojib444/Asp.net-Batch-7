

int[] arr = { 1};

Array.Sort(arr);
 IList<int> FindDisappearedNumbers(int[] nums)
{

   int  diff = 1;
    List<int> list = new List<int>();
    for(int i=0;i<nums.Length;i++)
    {
      if(diff!=nums[i]-i)
        {
            while(diff<nums[i]-i)
            {
                int f = nums[i]-(nums[i] - i) + diff;
                list.Add(f);
                diff++;
            }
            
        }
        if (nums[i] - i <diff)
        {
            int f = nums[i] - (nums[i] - i) + diff;
            list.Add(f);

        }
    }
    return list;
}

IList<int> result=FindDisappearedNumbers(arr);

foreach(var item in result)
{
    Console.WriteLine(item);
}



