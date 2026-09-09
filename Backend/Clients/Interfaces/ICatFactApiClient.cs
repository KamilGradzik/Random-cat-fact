using Backend.Models;

namespace Backend.Clients.Interfaces
{
    public interface ICatFactApiClient
    {
        public Task<CatFact?> FetchCatFactAsync();
    }
}