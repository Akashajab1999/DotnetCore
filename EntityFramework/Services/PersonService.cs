using Transflower.EntityFramework.Models;
using Transflower.EntityFramework.Repository;

namespace  Transflower.EntityFramework.Services;

public class PersonService : IPersonService
{

    IPersonRepository _service;

    public PersonService( IPersonRepository service){
        _service=service;
    }
    public List<Person> GetAll()=>_service.GetAll();
    
    public bool Insert(Person person)=>_service.Insert(person);

    public bool Update(Person person)=>_service.Update(person);

    public bool Delete(int personId)=>_service.Delete(personId);
}