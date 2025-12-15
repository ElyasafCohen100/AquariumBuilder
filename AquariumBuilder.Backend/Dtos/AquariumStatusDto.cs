namespace AquariumBuilder.Backend.Dtos
{
    public class AquariumStatusDto
    {
        public bool IsReady { get; set; }
        public int FishCount { get; set; }
        public double WaterTemperature { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
