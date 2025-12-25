using AquariumBuilder.Backend.Dtos.Fish;

namespace AquariumBuilder.Backend.Services.Interfaces
{
    public interface IFishService
    {
        public List<FishDto> GetAllFish();
        public void CreateFish(CreateFishDto createFishDto);
        public void UpdateFish(int id, UpdateFishDto updateFishDto);
    }
}