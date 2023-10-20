using Transflower.EntityFramework.Models;

namespace Transflower.EntityFramework.Repository;

public interface IPersonRepository{

    public List<Person> GetAll();
}