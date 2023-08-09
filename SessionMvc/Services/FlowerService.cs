using SessionMvc.Models;
using SessionMvc.Repositories.Interfaces;
using SessionMvc.Services.Interfaces;
using System.Collections.Generic;

namespace SessionMvc.Services
{
    public class FlowerService : IFlowerService 
    {
        private readonly IFlowerRepository _flowerRepo;
        public FlowerService(IFlowerRepository flowerRepo)
        {
            _flowerRepo = flowerRepo;
        }
        public List<Flower> GetAll() => _flowerRepo.GetAll();
        public Flower GetById(int id)=>_flowerRepo.GetById(id);
        public List<Flower> GetAllSold() => _flowerRepo.GetAllSold();
    }
}