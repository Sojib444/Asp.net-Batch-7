﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockData.Worker.Model
{
    public class CompanyWeb : ICompanyWeb
    {
        public string TradeCode { get => "Sojib"; set => throw new NotImplementedException(); }
    }
}
