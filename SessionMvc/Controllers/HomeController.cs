using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionMvc.Models;
using SessionMvc.Helpers;
namespace SessionMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

   public IActionResult Index(){  
            // will store string ,integer and complex object in to 
            // session maintained inside distributed Cache
            // at server side
            
            string SessionKeyName="product";
            string SessionKeyAge="age";
            HttpContext.Session.SetString(SessionKeyName,"Dell computer");
            HttpContext.Session.SetInt32(SessionKeyAge, 45);
            Cart theCart= SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if(theCart==null){
                theCart = new Cart();
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            }
            return View();
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
