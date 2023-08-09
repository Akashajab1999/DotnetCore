using SessionMvc.Models;
using System.Collections.Generic;

namespace SessionMvc.Repositories.Interfaces
{
    public interface IFruitRepository
    {
        List<Fruit> GetAllSold();
    }
}
