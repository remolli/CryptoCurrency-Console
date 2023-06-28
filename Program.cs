using CryptoCurrency_Console;
using CryptoCurrency_Console.Models;
using RestSharp;

API api = new API();
var response = await api.GetSymbolsAsync();

foreach (var item in response)
{
    string base_counter = item.Key;
    GetSymbolModel model = item.Value;

    Console.WriteLine();
    Console.WriteLine(base_counter);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(model.base_currency);
    Console.WriteLine(model.base_currency_scale);
    Console.WriteLine(model.counter_currency);
    Console.WriteLine(model.counter_currency_scale);
    Console.WriteLine(model.min_price_increment);
    Console.WriteLine(model.min_price_increment_scale);
    Console.WriteLine(model.min_order_size);
    Console.WriteLine(model.min_order_size_scale);
    Console.WriteLine(model.max_order_size);
    Console.WriteLine(model.max_order_size_scale);
    Console.WriteLine(model.lot_size);
    Console.WriteLine(model.lot_size_scale);
    Console.WriteLine(model.status);
    Console.WriteLine(model.id);
    Console.WriteLine(model.auction_price);
    Console.WriteLine(model.auction_size);
    Console.WriteLine(model.auction_time);
    Console.WriteLine(model.imbalance);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine();
    Console.WriteLine(new string('-', 30));
    Console.WriteLine(new string('/', 30));
    Console.WriteLine(new string('-', 30));
}

Console.ResetColor();






//var responser = await api.GetTickersAsync();

//foreach (var item in responser)
//{
//    Console.WriteLine();
//    Console.WriteLine(item.symbol);
//    Console.WriteLine(item.price_24h);
//    Console.WriteLine(item.volume_24h);
//    Console.WriteLine(item.last_trade_price);

//    Console.WriteLine();
//    Console.WriteLine(new string('-', 30));
//    Console.WriteLine(new string('/', 30));
//    Console.WriteLine(new string('-', 30));
//}