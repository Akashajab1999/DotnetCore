using Microsoft.EntityFrameworkCore.Diagnostics;
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


    public bool Insert(Person person){

        try{

            bool status =false;
            _personContext.Person.Add(person);
            status= SaveChanges(_personContext);
            return status;
        }
        catch(Exception){
            throw;
        }
    }


     private bool SaveChanges(PersonContext personContext)
        {
            int rowsAffected = personContext.SaveChanges();
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
}