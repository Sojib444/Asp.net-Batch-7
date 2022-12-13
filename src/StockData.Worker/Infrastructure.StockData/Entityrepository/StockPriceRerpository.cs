using Infrastructure.StockData.Entiies;
using Infrastructure.StockData.ORM;
using Infrastructure.StockData.ReposityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.Entityrepository
{
    public class StockPriceRerpository:Repository<StockPrice>,IStockPriceRepository
    {
        public StockPriceRerpository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override void Add(StockPrice Entity)
        {
            base.Add(Entity);
        }
    }
}
