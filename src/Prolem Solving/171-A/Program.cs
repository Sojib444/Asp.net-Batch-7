using System;
class Name
{
    static void Main()
    {
        for(int i=1000;i<=2000;i++)
        {
            string s = Convert.ToString(i);
            for(int j=0;j<=s.Length;j++)
            {
                for (int k = j + 1; k < s.Length; k++) ;
                
            }

        }
        
    }
}
