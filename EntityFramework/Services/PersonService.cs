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
    
}