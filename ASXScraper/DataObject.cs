using System;
using System.Collections.Generic;

namespace ASXScrapper
{
    public class DataObject
    {
        public string Code { get; set; }
        public string IsinCode { get; set; }
        public string DescFull { get; set; }
        public decimal LastPrice { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal DayHighPrice { get; set; }
        public decimal DayLowPrice { get; set; }
        public decimal ChangePrice { get; set; }
        public string ChangeInPercent { get; set; }
        public int Volume { get; set; }
        public decimal BidPrice { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal PreviousClosePrice { get; set; }
        public string PreviousDayPercentageChange { get; set; }
        public decimal YearHighPrice { get; set; }
        public DateTime LastTradeDate { get; set; }
        public DateTime YearHighDate { get; set; }
        public int YearLowPrice { get; set; }
        public DateTime YearLowDate { get; set; }
        public double Pe { get; set; }
        public double Eps { get; set; }
        public long AverageDailyVolume { get; set; }
        public double AnnualDividendYield { get; set; }
        public long MarketCap { get; set; }
        public long NumberOfShares { get; set; }
        public long DeprecatedMarketCap { get; set; }
        public long DeprecatedNumberOfShares { get; set; }
        public bool Suspended { get; set; }
        public List<string> Status { get; set; }
    }
}