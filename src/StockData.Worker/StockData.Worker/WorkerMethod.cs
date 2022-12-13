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

        public static List<List<string>> getStokprices( HtmlDocument doc)
        {
            List<List<string>> values = new List<List<string>>();

            var tbodyData = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered " +
                                  "background-white shares-table fixedHeader']/tbody/tr[1]/td");

            List<string> tbodyTdData = new List<string>();
            for(int i=1;i<tbodyData.Count;i++)
            {
                tbodyTdData.Add(tbodyData[i].InnerText.Trim());
            }
            values.Add(tbodyTdData);

            var tables = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered " +
                "background-white shares-table fixedHeader']/tr");

            foreach (var item in tables)
            {
                List<string> morTdDta = new List<string>();

                var td = item.ChildNodes;
                for(int i = 0;i < item.ChildNodes.Count; i++)
                {
                    if(i%2 != 0 && i != 1)
                    {
                        morTdDta.Add(td[i].InnerText.Trim());
                    }
                }
                values.Add(morTdDta);
            }

            return values;

        }
    }
}
