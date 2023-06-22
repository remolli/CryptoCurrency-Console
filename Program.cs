using CryptoCurrency_Console;
using CryptoCurrency_Console.Models;
using RestSharp;

// HUD
Console.WriteLine("Welcome to CryptoCurrency");
Console.WriteLine();
Console.WriteLine("Types of an asset id base");
Console.WriteLine("""
                  
                  Crypto:
                  BTC (bitcoin)   ETH (etherium)   BNB (BNB)
                  USDT (tether)   USDC (USD Coin)

                  Coin:
                  EUR (euro)   USD (dolar)   JPY (japanese yen)
                  GBP (pound sterling)   BRL (brazilian real)
                  
                  """);
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
    if (
         // CRYPTO
         quote == "BTC" || quote == "ETH" || quote == "BNB" || quote == "USDT" || quote == "USDC" ||

         // COIN
         quote == "EUR" || quote == "USD" || quote == "JPY" || quote == "GBP" || quote == "BRL"
        )
    {
        Console.WriteLine("Quote: " + item.asset_id_quote);
        Console.WriteLine("Rate: " + item.rate);
        Console.WriteLine("Time: " + item.time);
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
    }
}