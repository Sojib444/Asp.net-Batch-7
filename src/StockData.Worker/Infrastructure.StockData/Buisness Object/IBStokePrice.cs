namespace Infrastructure.StockData.Buisness_Object
{
    public interface IBStokePrice
    {
        double Change { get; set; }
        double ClosePrice { get; set; }
        int CompanyId { get; set; }
        double High { get; set; }
        double LastTradingPrice { get; set; }
        double Low { get; set; }
        double Trade { get; set; }
        double Value { get; set; }
        double Volume { get; set; }
        double YesterdayClosePrice { get; set; }
    }
}