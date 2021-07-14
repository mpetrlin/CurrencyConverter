using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IFetchLatestFromAPI
    {
        Task<string> FetchLatestRatesFromAPI();
    }
}