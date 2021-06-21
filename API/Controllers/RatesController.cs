using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;
        public RatesController(DataContext context, IConfiguration config)
        {
            _config = config;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Currency>>> GetRatesFromLocalDB()
        {
            return await _context.Rates.ToListAsync();
        }

        [HttpPost("update")]
        public async Task<Currency> FetchLatestRateFromAPI(string name)
        //public async Task<ActionResult<Currency>> FetchLatestRates()
        {
            string apikey = _config.GetValue<string>("OpenExchangeRates_API_key");
            string url = "https://openexchangerates.org/api/latest.json?app_id=" + apikey;
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            var responseString = await response.Content.ReadAsStringAsync();
            JsonDocument document = JsonDocument.Parse(responseString);
            JsonElement root = document.RootElement;

            var currency = new Currency
            {
                Timestamp = root.GetProperty("timestamp").GetDouble(),
                Name = name,
                Rate = root.GetProperty("rates").GetProperty(name).GetDouble()
            };

            _context.Rates.Add(currency);

            await _context.SaveChangesAsync();

            return currency;
        }
    }
}