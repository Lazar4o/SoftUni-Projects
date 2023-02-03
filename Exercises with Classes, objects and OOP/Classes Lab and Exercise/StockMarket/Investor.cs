using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {

        private List<Stock> portfolio;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Counter { get => portfolio.Count; }

        public int Count()
        {
            return Counter;
        }
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock currentStock = portfolio.FirstOrDefault(x => x.CompanyName == companyName);
            if (!portfolio.Any(stock => stock.CompanyName == companyName))
            {
               return $"{companyName} does not exist.";
            }
            else if (sellPrice < currentStock.PricePerShare)
            {
               return $"Cannot sell {companyName}.";
            }
            portfolio.Remove(currentStock);
            MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }
        public Stock FindStock(string companyName)
        {
            return portfolio.FirstOrDefault(x => x.CompanyName == companyName);
        }
        public Stock FindBiggestCompany()
        {
            var orderedList = portfolio.OrderByDescending(x => x.MarketCapitalization);
            Stock biggestCompany = orderedList.FirstOrDefault();
            return biggestCompany;
        }
        public string InvestorInformation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in portfolio)
            {
                stringBuilder.AppendLine($"Company: {stock.CompanyName}");
                stringBuilder.AppendLine($"Director: {stock.Director}");
                stringBuilder.AppendLine($"Price per share: ${stock.PricePerShare}");
                stringBuilder.AppendLine($"Market capitalization: ${stock.MarketCapitalization:f2}");
            }
            return stringBuilder.ToString().TrimEnd();
            // The investor Peter Lynch with a broker Fidelity has stocks:
            // Company: Tesla
            // Director: Elon Musk
            // Price per share: $743.17

        }
    }
}