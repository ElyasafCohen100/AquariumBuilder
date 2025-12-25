namespace AquariumBuilder.Backend.Dtos.Aquarium
{
    public class AquariumRecommendationsDto
    {
        public int Count { get; set; }
        public List<string> Recommendations { get; set; } = new();
    }
}
