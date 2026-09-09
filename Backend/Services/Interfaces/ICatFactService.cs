using Backend.Models;

namespace Backend.Services.Interfaces
{
    public interface ICatFactService
    {
        public Task<CatFact> GetRandomCatFact();
    }
}