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
    public class CompnayRepository:Repository<Company>,ICompanyRepository
    {
        public CompnayRepository(ApplicationDbContext dbContext):base(dbContext)
        {

        }

        public override void Add(Company Entity)
        {
            base.Add(Entity);
        }
    }
}
