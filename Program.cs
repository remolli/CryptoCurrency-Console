using CryptoCurrency_Console;
using RestSharp;

// Base crypto for request
string asset_id_base = "BTC";

// Request
var options = new RestClientOptions("https://rest.coinapi.io");
var client = new RestClient(options);
var request = new RestRequest($"/v1/exchangerate/{asset_id_base}");
request.AddHeader("X-CoinAPI-Key", "11CA632B-F6B4-419E-8E88-65246C594C97");
//                                        This <T> is the Model class deserialized
var requestDeserialized = await client.GetAsync<ModelRequest>(request);

// View
Console.WriteLine(requestDeserialized.asset_id_base);
int i = 0;
foreach (var item in requestDeserialized.rates)
{
    Console.WriteLine(item.asset_id_quote);
    Console.WriteLine(item.time);
    Console.WriteLine(item.rate);
    Console.WriteLine(new string('-', 30));
    
    // i = number of convertions
    if (i == 5)
    {
        break;
    }
    i++;
}