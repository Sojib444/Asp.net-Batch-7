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

        public Worker(ILogger<Worker> logger, ICompanyService companyService, IMapper mapper,
            ICompanyWeb web, ILifetimeScope scope)
        {
            _logger = logger;
            _companyService = companyService;
            _mapper = mapper;
            this.web = web;
            _scope = scope;
        }

        public string url { get; set; }
        public HtmlWeb website { get; set; }
        public HtmlDocument doc { get; set; }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            url = "https://www.dse.com.bd/latest_share_price_scroll_l.php";
            website = new HtmlWeb();
            Console.WriteLine("Hi");
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
                var tableNodes = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered " +
                    "background-white shares-table fixedHeader']//tr");

                if (statusNodeText == "Closed")
                {
                    WorkerMethod.getStokprices(tableNodes, doc);
                }
                else
                {
                    Log.Write(LogEventLevel.Warning, "Market is closed");
                }

                await Task.Delay(1000, stoppingToken);
            }
        }



    }
}