using SessionMvc.Models;
using System.Collections.Generic;

namespace SessionMvc.Repositories.Interfaces
{
    public interface IFlowerRepository
    {
        List<Flower> GetAll();
        Flower GetById(int id);
        List<Flower> GetAllSold();
    }
}
