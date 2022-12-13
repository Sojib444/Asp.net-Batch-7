using Autofac;
using AutoMapper;
using HtmlAgilityPack;
using Infrastructure.StockData.Buisness_Object;
using Infrastructure.StockData.Service;
using Serilog;
using Serilog.Events;
using StockData.Worker.Model;

namespace StockData.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        private readonly ICompanyWeb web;
        private readonly ILifetimeScope _scope;
        private readonly IStockPriceService _stockPriceService;

        public Worker(ILogger<Worker> logger, ICompanyService companyService, IMapper mapper,
            ICompanyWeb web, ILifetimeScope scope,IStockPriceService stockPriceService)
        {
            _logger = logger;
            _companyService = companyService;
            _mapper = mapper;
            this.web = web;
            _scope = scope;
            _stockPriceService = stockPriceService;
        }

        public string url { get; set; }
        public HtmlWeb website { get; set; }
        public HtmlDocument doc { get; set; }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            url = "https://www.dse.com.bd/latest_share_price_scroll_l.php";
            website = new HtmlWeb();
            doc = website.Load(url);

            var htmlNodes = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered " +
                        "background-white shares-table fixedHeader']//tr");

            var companyCode = WorkerMethod.InsertCompany(htmlNodes, doc);

            if (companyCode.Count > 390)
            {
                for (int i = 0; i < companyCode.Count; i++)
                {
                    CompanyWeb cweb = new CompanyWeb();
                    cweb.TradeCode = companyCode[i];
                    var bCompany = _mapper.Map<BCompany>(cweb);
                    _companyService.Add(bCompany);
                }
            }


            return base.StartAsync(cancellationToken);

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var statusNodeText = doc.DocumentNode.SelectSingleNode("//span[@class='green']").InnerText;

                if (statusNodeText == "Open")
                {
                   var stockprices= WorkerMethod.getStokprices(doc);
                   
                    for(int i=0;i<stockprices.Count;i++)
                    {
                        int j = 0;

                        StockPriceWeb priceweb = new StockPriceWeb();

                        priceweb.CompanyId =(string) stockprices[i][j]; 
                        priceweb.LastTradingPrice =Convert.ToDouble( stockprices[i][j=j+1]);
                        priceweb.High = Convert.ToDouble(stockprices[i][j=j+1]);
                        priceweb.Low = Convert.ToDouble(stockprices[i][++j]);
                        priceweb.ClosePrice = Convert.ToDouble(stockprices[i][++j]);
                        priceweb.YesterdayClosePrice = Convert.ToDouble(stockprices[i][++j]);
                        string change = stockprices[i][++j];
                        if(change=="--")
                        {
                            priceweb.Change = 0;
                        }
                        else
                        {
                            priceweb.YesterdayClosePrice = Convert.ToDouble(change);
                        }

                        priceweb.Trade = Convert.ToDouble(stockprices[i][++j]);
                        priceweb.Value = Convert.ToDouble(stockprices[i][++j]);
                        priceweb.Volume = Convert.ToDouble(stockprices[i][++j]);

                        j = 0;

                        var bstockPrice = _mapper.Map<BStokePrice>(priceweb);
                        _stockPriceService.Add(bstockPrice);

                    }

                    Log.Write(LogEventLevel.Information, "Data is Inserting");

                }
                else
                {
                    Log.Write(LogEventLevel.Warning, "Market is closed");
                }

                await Task.Delay(5000, stoppingToken);
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            Log.Write(LogEventLevel.Information, "Worker is Closed");
            return base.StopAsync(cancellationToken);
        }



    }
}