﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.StockData.Entiies
{
    public class StockPrice
    {
        public int  Id { get; set; }
        public string  CompanyId { get; set; }
        public double LastTradingPrice { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double ClosePrice { get; set; }
        public double YesterdayClosePrice { get; set; }
        public double Change { get; set; }
        public double Trade { get; set; }
        public double Value { get; set; }
        public double Volume { get; set; }
        public DateTime DateTime { get => DateTime.UtcNow; set=>value=DateTime.UtcNow; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
