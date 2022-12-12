using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.StockData.Entiies
{
    public class Company
    {
        public int Id { get; set; }
        [Key]
        public string TradeCode { get; set; }
        public List<StockPrice> StockPrice { get; set; }
    }
}
