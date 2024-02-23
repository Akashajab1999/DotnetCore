using Microsoft.AspNetCore.Mvc;
using TFLPortal.Models;
using TFLPortal.Services;

namespace DisconnectedWebApi.Controllers;

[ApiController]
[Route("api/project")]
public class ProjectController : ControllerBase
{
   private readonly IProjectService _projectService;

 public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }


[HttpPut("update")]
 public bool Update( Project project){
   bool status =false;
   status=_projectService.Update(project);
       return status; 
    }

    [HttpPost("Insert")]
 public bool Insert( Project project){
   bool status =false;
   status=_projectService.Insert(project);
       return status; 
    }


[HttpGet("projects")]
 public List<Project> GetProjects(){
  
    return _projectService.GetProjects(); 
    }
}
