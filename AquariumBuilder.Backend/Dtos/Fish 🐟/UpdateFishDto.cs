using AquariumBuilder.Backend.Enums;

namespace AquariumBuilder.Backend.Dtos.Fish
{
    public class UpdateFishDto
    {
        public string Name { get; set; } = string.Empty;
        public bool isAlive { get; set; }
        public int AgeInDays { get; set; }
        public FishHealthStatusEnum HealthStatus { get; set; }
    }
}
