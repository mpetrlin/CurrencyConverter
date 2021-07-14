using System.Net.Http;
using System.Threading.Tasks;
using API.Interfaces;
using Microsoft.Extensions.Configuration;

namespace API.Services
{
    public class FetchLatestFromAPI : IFetchLatestFromAPI
    {
        private readonly IConfiguration _config;
        public FetchLatestFromAPI(IConfiguration config)
        {
            _config = config;
        }

        public async Task<string> FetchLatestRatesFromAPI()
        {
            string apiKey = _config.GetValue<string>("OpenExchangeRates_API_key");
            string url = "https://openexchangerates.org/api/latest.json?app_id=" + apiKey;
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            return await response.Content.ReadAsStringAsync();
            
        }
    }
}