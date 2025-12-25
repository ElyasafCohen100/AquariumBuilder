using AquariumBuilder.Backend.Enums;

namespace AquariumBuilder.Backend.Dtos.Aquarium
{
    public class AquariumSummaryDto
    {
        public AquariumOverallStatusEnum OverallStatus { get; set; }
        public string StatusMessage { get; set; } = string.Empty;
        public int WarningCount { get; set; }   
    }
}
