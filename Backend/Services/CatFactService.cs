using Backend.Clients.Interfaces;
using Backend.Models;
using Backend.Repositories.Intrerfaces;
using Backend.Services.Interfaces;

namespace Backend.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly ICatFactApiClient _apiClient;
        private readonly ICatFactRepository _repository;
        
        public CatFactService(ICatFactApiClient apiClient, ICatFactRepository repository)
        {
            _apiClient = apiClient;
            _repository = repository;
        }

        public async Task<CatFact> GetRandomCatFact()
        {
            var catFact = await _apiClient.FetchCatFactAsync();
            if(catFact != null)
            {
                await _repository.SaveCatFact(catFact);
                return catFact;
            }
            else throw new InvalidOperationException("Something wrong! Cannot get cat fact.");
        }
    }
}