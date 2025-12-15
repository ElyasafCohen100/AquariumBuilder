using AquariumBuilder.Backend.Dtos;
using AquariumBuilder.Backend.Services.Interfaces;


namespace AquariumBuilder.Backend.Services
{
    public class AquariumService : IAquariumService
    {
        public AquariumStatusDto GetStatus()
        {
            return new AquariumStatusDto()
            {
                IsReady = true,
                FishCount = 10,
                WaterTemperature = 26.0,
                Status = "Aquarium is healthy"
            };
        }
    }
}
