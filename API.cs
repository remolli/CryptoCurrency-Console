using CryptoCurrency_Console.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrency_Console
{
    public class API
    {
        RestClient client;
        public API()
        {
            var options = new RestClientOptions("https://api.blockchain.com/v3/exchange");
            client = new RestClient(options);
        }
        public async Task<GetTickerModel[]> GetTickersAsync()
        {
            var request = new RestRequest($"/tickers");
            request.AddHeader("X-API-Token", "7905f5e7-94c4-44f4-a229-d496e9c3d7a1");
            var requestDeserialized = await client.GetAsync<GetTickerModel[]>(request);
            return requestDeserialized;
        }
        public async Task<GetTickerModel> GetTickerAsync(string symbol)
        {
            var request = new RestRequest($"/tickers/{symbol}");
            request.AddHeader("X-API-Token", "7905f5e7-94c4-44f4-a229-d496e9c3d7a1");
            var requestDeserialized = await client.GetAsync<GetTickerModel>(request);
            return requestDeserialized;
        }
        public async Task<Dictionary<string, GetSymbolModel>> GetSymbolsAsync()
        {
            var request = new RestRequest($"/symbols");
            request.AddHeader("X-API-Token", "7905f5e7-94c4-44f4-a229-d496e9c3d7a1");
            var requestDeserialized = await client.GetAsync<Dictionary<string,GetSymbolModel>>(request);
            return requestDeserialized;
        }
        public async Task<GetSymbolModel> GetSymbolAsync(string symbol)
        {
            var request = new RestRequest($"/symbols/{symbol}");
            request.AddHeader("X-API-Token", "7905f5e7-94c4-44f4-a229-d496e9c3d7a1");
            var requestDeserialized = await client.GetAsync<GetSymbolModel>(request);
            return requestDeserialized;
        }
    }
}
