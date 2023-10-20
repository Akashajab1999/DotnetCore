using Transflower.EntityFramework.Models;
using Transflower.Repositories.Context;

namespace Transflower.EntityFramework.Repository;

public class PersonRepository : IPersonRepository

{

    private PersonContext _personContext;

    public PersonRepository(PersonContext personContext){
         _personContext=personContext;
    }
    public List<Person> GetAll()
    { 
        try{
        List<Person> peoples= _personContext.Person.ToList();

        return peoples;
        }
        catch(Exception){
             throw;
        }
    }
}