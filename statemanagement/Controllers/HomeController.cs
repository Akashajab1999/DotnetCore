using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using statemanagement.Models;

namespace statemanagement.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetString("UserName", "JohnDoe");
        
        // Retrieve session data

        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.UserName = HttpContext.Session.GetString("UserName");
         
        return View();
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
