using Infrastructure.StockData.Buisness_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.Service
{
    public interface ICompanyService
    {
        void Add(BCompany argCompany);
    }
}
