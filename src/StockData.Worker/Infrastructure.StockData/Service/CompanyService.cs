using Infrastructure.StockData.Buisness_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.Service
{
    public class CompanyService
    {
        public CompanyService(IBCompany company)
        {
            Company = company;
        }

        public IBCompany Company { get; }

        public void Add(BCompany argCompany)
        {

        }
    }
}
