using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using TFLPortal.Models;
using TFLPortal.Services;

namespace MvcApp.Controllers;

public class ProjectController : Controller
{


  private readonly IProjectService _projectService;
    public ProjectController(IProjectService projectService)
    {
       _projectService=projectService;
    }

   
     public IActionResult GetProject(int id)
    {

        Project project=_projectService.GetProject(id);
         // ViewData["Project"]=project;
           return View(project);
    }


   
     public IActionResult Insert(Project project)
    {
        bool status=_projectService.Insert(project);
         ViewData["InsertProject"]=status;
       return View();
    }

    public  async Task<IActionResult> GetProjects()
    {
       List<Project> projects= await _projectService.GetProjects();
          ViewData["Projects"]=projects;
           return View(projects);
    }


 [HttpGet]
    public IActionResult Update(int id)
    {   
       Project project=_projectService.GetProject(id);
       return View(project);
    }

    [HttpPost]
    public IActionResult Update(Project project)
    {   
        bool status=_projectService.Update(project);
       return RedirectToAction("Index","Home");
    }

    


    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
