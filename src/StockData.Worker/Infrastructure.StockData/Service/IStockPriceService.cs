using Infrastructure.StockData.Buisness_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.Service
{
    public interface IStockPriceService
    {
        void Add(BStokePrice argCompany);
    }
}
