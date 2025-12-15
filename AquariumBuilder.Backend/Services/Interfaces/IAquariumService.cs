using AquariumBuilder.Backend.Dtos;


namespace AquariumBuilder.Backend.Services.Interfaces
{
    public interface IAquariumService
    {
       public AquariumStatusDto GetStatus();
    }
}
