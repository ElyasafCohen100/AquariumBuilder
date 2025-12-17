namespace AquariumBuilder.Backend.Dtos.Aquarium
{
    public class AquariumWarningsDto
    {
        public int Count { get; set; }
        public List<string> Warnings { get; set; } = new();
    }
}
