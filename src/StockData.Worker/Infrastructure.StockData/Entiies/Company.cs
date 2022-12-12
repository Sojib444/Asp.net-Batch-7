using Microsoft.EntityFrameworkCore;

namespace Infrastructure.StockData.Entiies
{
    public class Company
    {
        public int Id { get; set; }
        public string TradeCode { get; set; }
    }
}
