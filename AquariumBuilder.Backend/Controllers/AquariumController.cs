using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AquariumBuilder.Backend.Dtos.Aquarium;
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


        // ================================= the Endpoints ================================= //

        [HttpGet("status")] // Descriptive
        public ActionResult<AquariumStatusDto> GetStatus()
        {
            AquariumStatusDto status = this._aquariumService.GetStatus();

            if (!status.IsReady)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, status);
            }
            return Ok(status);
        }

        [HttpGet("health")] // Infrastructure
        public ActionResult<AquariumHealthDto> GetHealth()
        {
            AquariumStatusDto status = this._aquariumService.GetStatus();
           
            return Ok(new AquariumHealthDto()
            {
                IsReady = status.IsReady,
                OverallStatus = status.OverallStatus
            });
        }

        [HttpGet("warnings")] // Informational
        public ActionResult<List<AquariumWarningsDto>> GetWarnings()
        {
            AquariumStatusDto status = this._aquariumService.GetStatus();
            return Ok(new AquariumWarningsDto()
            {
                Count = status.Warnings.Count,
                Warnings = status.Warnings
            });
        }
    }
}
