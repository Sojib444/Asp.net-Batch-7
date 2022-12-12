using HtmlAgilityPack;

namespace StockData.Worker
{
    public class WorkerMethod
    {
        public static List<string> InsertCompany(HtmlNodeCollection companyNodes, HtmlDocument doc)
        {
            List<String>? comapnyId = new List<string>();

            var TrDtaException = doc.DocumentNode.SelectSingleNode("//table[@class='table table-bordered " +
                                  "background-white shares-table fixedHeader']/tbody/tr[1]/td[2]/a");
            comapnyId.Add(TrDtaException.InnerText.Trim());

            for (int i = 1; i < companyNodes.Count - 1; i++)
            {
                var TrDta = doc.DocumentNode.SelectSingleNode($"//table[@class='table table-bordered " +
                                        $"background-white shares-table fixedHeader']/tr[{i}]/td[2]");
                comapnyId.Add(TrDta.InnerText.Trim());

            }
            return comapnyId;
        }
    }
}
