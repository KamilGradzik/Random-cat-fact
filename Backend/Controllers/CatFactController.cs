using Backend.Models;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/cat-facts/")]
    public class CatFactController : Controller
    {   
        private readonly ICatFactService _catFactService;
        public CatFactController(ICatFactService catFactService)
        {
            _catFactService = catFactService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCatFact()
        {
            CatFact CatFact = await _catFactService.GetRandomCatFact();
            return Ok(CatFact);
        }

        // [HttpGet]
        // public async Task<IActionResult> DownloadCatFacts()
        // {
        //     CatFact CatFact = await _catFactService.GetRandomCatFact();
        //     if (CatFact != null)
        //     {
        //         return Ok(CatFact);
        //     }
        //     return NotFound("Cat fact cannot be found!");
        // }
    }
}