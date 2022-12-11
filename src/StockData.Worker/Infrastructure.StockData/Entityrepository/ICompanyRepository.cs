using Infrastructure.StockData.Entiies;
using Infrastructure.StockData.ReposityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.Entityrepository
{
    public interface ICompanyRepository:IRepository<Company>
    {
    }
}
