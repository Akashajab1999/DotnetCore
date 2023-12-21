using Microsoft.EntityFrameworkCore.Diagnostics;
using MySql.Data.MySqlClient;
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


    public bool Update(Person person){

        try{

            bool status = false;
            var oldPerson= _personContext.Person.Find(person.Id);
            if(oldPerson is not null){

                oldPerson.Id=person.Id;
                oldPerson.Name=person.Name;
               status=SaveChanges(_personContext); 
            }
           return status;
        }

        catch(Exception){
            throw;

        }
    }

     public bool Delete(int personId){

        try{

            bool status = false;
            var oldPerson= _personContext.Person.Find(personId);
            if(oldPerson is not null){

            _personContext.Remove(oldPerson);
            status=SaveChanges(_personContext);
            }
           return status;
        }

        catch(Exception){
            throw;

        }
    }
}