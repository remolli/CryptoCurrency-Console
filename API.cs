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
            var options = new RestClientOptions("https://rest.coinapi.io");
            client = new RestClient(options);
        }
        public async Task<GetExchangeRateModel> GetExchangeRateAsync(string asset_id_base)
        {
            var request = new RestRequest($"/v1/exchangerate/{asset_id_base}");
            request.AddHeader("X-CoinAPI-Key", "11CA632B-F6B4-419E-8E88-65246C594C97");
            var requestDeserialized = await client.GetAsync<GetExchangeRateModel>(request);
            return requestDeserialized;
        }
    }
}
