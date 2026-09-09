using Backend.Models;

namespace Backend.Repositories.Intrerfaces
{
    public interface ICatFactRepository
    {
        public Task SaveCatFact(CatFact CatFact);
    }
}