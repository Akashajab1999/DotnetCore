using SessionMvc.Models;
using SessionMvc.Repositories.Interfaces;
using SessionMvc.Services.Interfaces;
using System.Collections.Generic;

namespace SessionMvc.Services
{
    public class FruitService : IFruitService
    {
        private readonly IFruitRepository _FruitRepo;

        public FruitService(IFruitRepository FruitRepo)
        {
            _FruitRepo = FruitRepo;
        }
        public List<Fruit> GetAllSold() => _FruitRepo.GetAllSold();
    }
}