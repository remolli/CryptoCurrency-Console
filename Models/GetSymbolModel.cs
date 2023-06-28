using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CryptoCurrency_Console.Models
{
    public class GetSymbolsModel
    {
        public Dictionary<string,GetSymbolModel> models { get; set; }
    }

    public class GetSymbolModel
    {
        public string base_currency { get; set; }
        public double base_currency_scale { get; set; }
        public string counter_currency { get; set; }
        public double counter_currency_scale { get; set; }
        public double min_price_increment { get; set; }
        public double min_price_increment_scale { get; set; }
        public double min_order_size { get; set; }
        public double min_order_size_scale { get; set; }
        public double max_order_size { get; set; }
        public double max_order_size_scale { get; set; }
        public double lot_size { get; set; }
        public double lot_size_scale { get; set; }
        public string status { get; set; }
        public double id { get; set; }
        public double auction_price { get; set; }
        public double auction_size { get; set; }
        public string auction_time { get; set; }
        public double imbalance { get; set; }
    }
}

