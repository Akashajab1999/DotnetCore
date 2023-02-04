using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DIWebApp.Models;
using DIWebApp.Services;

namespace DIWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
        // SOA:Service Oriented Architecture
        // dependencies : service
        // data members:
        private readonly IHelloWorldService _helloWorldService;
        private readonly IProductCatalogService _productCatalogService;
      // Constuctor Dependency Injection
        public HomeController(IHelloWorldService helloWorldService,IProductCatalogService productCatalogSerivce)
        {
           //are used for initalization
           this._helloWorldService=helloWorldService;
           this._productCatalogService=productCatalogSerivce;
        }

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
         string message=this._helloWorldService.SaysHello();
            ViewData["message"]=message;
            bool status=this._productCatalogService.Insert();

        return View();
    }

    public IActionResult Privacy()
    {
         string message=this._helloWorldService.SaysHello();
            ViewData["message"]=message;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
