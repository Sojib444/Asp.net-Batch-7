using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.BusinessObject
{
    public class BStudent
    {
        public string? BName { get; set; }
        public string? BAddress { get; set; }
        public string? BEmail { get; set; }
        public DateTime BDateTime { get; set; }
        public double BCGPA { get; set; }


        public void anyLogic()
        {
            if(BCGPA<3)
            {
                BCGPA = 3;
                Console.WriteLine("Hi this is Business Logic");
            }
        }
    }
}
