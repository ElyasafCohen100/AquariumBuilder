using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AquariumBuilder.Backend.Dtos.Fish;
using AquariumBuilder.Backend.Services.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace AquariumBuilder.Backend.Controllers.Fish___
{
    [ApiController]
    [Route("api/[controller]")]
    public class FishController : ControllerBase
    {
        // === Dependency Injection === //
        private readonly IFishService _fishService;

        // ========== constructor ========== //
        public FishController(IFishService ifishService)
        {
            this._fishService = ifishService;
        }

        // ================================= the Endpoints ================================= //

        [HttpGet] // to get all fish
        public ActionResult<List<FishDto>> GetAllFish()
        {
            List<FishDto> fishList = this._fishService.GetAllFish();
            return Ok(fishList);
        }

        [HttpPost] // to buy a fish
        public IActionResult CreateFish([FromBody] CreateFishDto createFishDto)
        {
            this._fishService.CreateFish(createFishDto);
            return Ok();
        }

        [HttpPut("{id}")] // to update fish info
        public IActionResult UpdateFish(int id, [FromBody] UpdateFishDto updateFishDto)
        {
            this._fishService.UpdateFish(id, updateFishDto);
            return NoContent();
        }
    }
}
