

    int t=Convert.ToInt32(Console.ReadLine());

   
    while (t>0)
    {

        string s=Console.ReadLine();
        

        for (int i = 0; i < s.Length; i = i + 2)
        {
        Console.Write(s[i]); ;
        }
    Console.Write(s[s.Length- 1]); 
    Console.WriteLine();
    t--;
    }



