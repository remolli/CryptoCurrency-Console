using CryptoCurrency_Console;
using CryptoCurrency_Console.Models;
using RestSharp;

// HUD
Console.WriteLine("Welcome to CryptoCurrency");
Console.WriteLine();
Console.WriteLine("asset id base => BTC ");
Console.WriteLine();
Console.Write("Insert an 'asset id base': ");
// Base crypto for request
string asset_id_base = Console.ReadLine();

// Request
API api = new API();
api.GetExchangeRateAsync(asset_id_base);
var requestDeserialized = await api.GetExchangeRateAsync(asset_id_base);

// Verifying null response
if (requestDeserialized.rates == null)
{
    Console.WriteLine();
    Console.WriteLine("Null rates");
    Console.WriteLine("Exiting...");
    Environment.Exit(0);
}

// View
Console.WriteLine();
Console.WriteLine(requestDeserialized.asset_id_base);

foreach (var item in requestDeserialized.rates)
{
    string quote = item.asset_id_quote;

    // quote is the curency acronym rate
    if (quote == "USD" || quote == "EUR")
    {
        Console.WriteLine(item.asset_id_quote);
        Console.WriteLine(item.time);
        Console.WriteLine(item.rate);
        Console.WriteLine(new string('-', 30));
    }
}