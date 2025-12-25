using AquariumBuilder.Backend.Enums;

namespace AquariumBuilder.Backend.Dtos.Fish
{
    public class CreateFishDto
    {
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public int AgeInDays { get; set; }
    }
}
