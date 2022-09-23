using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.BusinessObject
{
    public class BBook
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public int Price { get; set; }

        public void BookLogic()
        {
            if(Price<0)
            {
                Price = 50;
            }
        }
    }
}
