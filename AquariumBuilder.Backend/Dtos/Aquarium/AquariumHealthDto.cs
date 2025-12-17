using AquariumBuilder.Backend.Enums;

namespace AquariumBuilder.Backend.Dtos.Aquarium
{
    public class AquariumHealthDto
    {
        public bool IsReady { get; set; }
        public AquariumOverallStatusEnum OverallStatus { get; set; }
    }
}
