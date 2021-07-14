using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IFetchLatestFromAPI _apidata;

        public RatesController(DataContext context, IFetchLatestFromAPI apidata)
        {
            _apidata = apidata;
            _context = context;
        }

        [HttpGet("getrates")]
        public async Task<ActionResult<Rates>> GetLatestRatesFromLocalDB()
        {
            return await _context.Rates.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
        }
        
        [HttpGet("getallrates")]
        public async Task<ActionResult<IEnumerable<Rates>>> GetAllRatesFromLocalDB()
        {
            return await _context.Rates.ToListAsync();
        }

        [HttpGet("update")]
        public async Task<ActionResult<Rates>> UpdateRatesFromAPI()
        {                                 
            JsonDocument document = JsonDocument.Parse(_apidata.FetchLatestRatesFromAPI().Result);
            JsonElement root = document.RootElement;
            
            Rates rates = JsonSerializer.Deserialize<Rates>(root.GetProperty("rates").ToString());
            rates.timestamp = root.GetProperty("timestamp").GetDouble();
            
            _context.Rates.AddRange(rates);

            await _context.SaveChangesAsync();

            return Ok(rates);
        }

        [HttpGet("deleteold")]
        public async Task<ActionResult<Rates>> DeleteDataInDatabase()
        {
            _context.Rates.RemoveRange(_context.Rates.First());
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}