using HtmlAgilityPack;
using System.Xml;

namespace StockData.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;


        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.dse.com.bd/latest_share_price_scroll_l.php");
            var table = doc.DocumentNode.SelectSingleNode("//table[@class='table table-bordered " +
                "background-white shares-table fixedHeader']/tbody/tr");
            var childs = table.ChildNodes;

            foreach(var item in childs)
            {
                if (item.Descendants("a").Any())
                {
                    Console.WriteLine(item.Descendants("a").ToList()[0].InnerHtml.Trim());
                }
                else
                Console.WriteLine(item.InnerHtml.Trim());
            }

            var tables = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered " +
                "background-white shares-table fixedHeader']/tr");

            //Console.WriteLine(table.OuterHtml);

            foreach (var item in tables)
            {
                foreach(var items in item.ChildNodes)
                {
                    Console.WriteLine(items.InnerText);
                }
            }






        }
    }
}