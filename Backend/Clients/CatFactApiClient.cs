using Backend.Clients.Interfaces;
using Backend.Models;

namespace Backend.Clients
{
    public class CatFactApiClient : ICatFactApiClient
    {
        private readonly HttpClient _client;
        public CatFactApiClient(HttpClient client) { _client = client; }
        public async Task<CatFact?> FetchCatFactAsync()
        {
            var response = await _client.GetFromJsonAsync<CatFact>("https://catfact.ninja/fact");
            return response;
        }
    }
}