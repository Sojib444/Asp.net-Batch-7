using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.UnifOfWork
{
    public interface IApplicationUnitofWork:IDisposable
    {
        public void Save();
    }
}
