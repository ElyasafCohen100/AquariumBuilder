using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AquariumBuilder.Backend.Dtos;
using AquariumBuilder.Backend.Services.Interfaces;



namespace AquariumBuilder.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AquariumController : ControllerBase
    {

        // === Dependency Injection === //
        private readonly IAquariumService _aquariumService;

        // ========== constructor ========== //
        public AquariumController(IAquariumService aquariumService)
        {
            this._aquariumService = aquariumService;
        }


        // ========================== the Endpoints ========================== //

        [HttpGet]
        public ActionResult<AquariumStatusDto> GetStatus()
        {
            AquariumStatusDto status = this._aquariumService.GetStatus();
            return Ok(status);
            
        }
    }
}
