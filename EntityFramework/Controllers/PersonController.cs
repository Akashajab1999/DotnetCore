using Microsoft.AspNetCore.Mvc;
using Transflower.EntityFramework.Models;
using Transflower.EntityFramework.Services;

namespace Transflower.EntityFramework.Controller;
[ApiController]
[Route("api/projects")]
public class PersonController:ControllerBase{


private readonly IPersonService _personService;

public PersonController(IPersonService personService){

    _personService=personService;
}

[HttpGet]
public List<Person> GetAll(){
    
    List<Person>  peoples = _personService.GetAll();

    return peoples;
}

}