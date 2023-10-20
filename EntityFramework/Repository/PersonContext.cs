using Microsoft.EntityFrameworkCore;
using Transflower.EntityFramework.Models;


namespace Transflower.Repositories.Context;

public class PersonContext:DbContext{

    public DbSet<Person> Person{get;set;}


    public PersonContext(DbContextOptions options):base(options){
        Person=Set<Person>();
        
    }
}