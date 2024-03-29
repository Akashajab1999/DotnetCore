using Transflower.EntityFramework.Models;

namespace Transflower.EntityFramework.Repository;

public interface IPersonRepository{

    public List<Person> GetAll();

    public bool Insert(Person person);

    public bool Update(Person person);

     public bool Delete(int personId);
}