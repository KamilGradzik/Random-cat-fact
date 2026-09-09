using Backend.Models;
using Backend.Repositories.Intrerfaces;

namespace Backend.Repositories
{
    public class CatFactRepository : ICatFactRepository
    {   
        private readonly string _filePath = "./Data/Cat-facts.txt"; 

        public async Task SaveCatFact(CatFact CatFact)
        {
            using StreamWriter writer = File.AppendText(_filePath);
            await writer.WriteLineAsync($"{CatFact.Fact} ({CatFact.Length} znaków)\n");
        }
    }
}