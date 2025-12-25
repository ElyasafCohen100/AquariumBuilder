using System.Xml.Linq;
using AquariumBuilder.Backend.Enums;
using AquariumBuilder.Backend.Dtos.Fish;
using AquariumBuilder.Backend.Services.Interfaces;


namespace AquariumBuilder.Backend.Services.Fish
{
    public class FishService : IFishService
    {

        private readonly List<FishDto> _fishList = new List<FishDto>();

        public List<FishDto> GetAllFish()
        {
            return this._fishList;
        }


        public void CreateFish(CreateFishDto createFishDto)
        {
            FishDto newFish = new FishDto
            {
                Name = createFishDto.Name,
                Species = createFishDto.Species,
                AgeInDays = createFishDto.AgeInDays,
            };

            this._fishList.Add(newFish);
        }


        public void UpdateFish(int id, UpdateFishDto updateFishDto)
        {
            FishDto? fishToUpdate = this._fishList.FirstOrDefault(f => f.Id == id);  
               
            if(fishToUpdate == null)
            {
                return;
            }

            fishToUpdate.Name = updateFishDto.Name;
            fishToUpdate.isAlive = updateFishDto.isAlive;
            fishToUpdate.AgeInDays = updateFishDto.AgeInDays;
            fishToUpdate.HealthStatus = updateFishDto.HealthStatus;
        }
    }
}
