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

        public static List<List<object>> getStokprices(HtmlNodeCollection companyNodes, HtmlDocument doc)
        {
            List<List<object>> values = new List<List<object>>();

            var tbodyData = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered " +
                                  "background-white shares-table fixedHeader']/tbody/tr[1]/td");

            List<object> tbodyTdData = new List<object>();
            for(int i=1;i<tbodyData.Count;i++)
            {
                tbodyTdData.Add(tbodyData[i].InnerText.Trim());
            }
            values.Add(tbodyTdData);

            var tables = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered " +
                "background-white shares-table fixedHeader']/tr");

            foreach (var item in tables)
            {
                int i = 2;

                List<object> morTdDta = new List<object>();
                foreach (var td in item.ChildNodes)
                {
                    if (i%2==0 || i==3)
                    {
                        i++;
                        continue;
                    }
                    else
                    {
                        morTdDta.Add(td.InnerText.Trim());
                    }
                }

                values.Add(morTdDta);
                i = 2;
            }

            return values;

        }
    }
}
