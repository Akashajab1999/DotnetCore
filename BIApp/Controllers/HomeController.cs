using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BIApp.Models;

namespace BIApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
     public IActionResult AboutUs()
    {
        //Using ViewData
        string name="Transflower Learning Pvt . Ltd";
        ViewData["company"] = name;
        return View();
    }

     public IActionResult ContactUs()
    {
        //USingViewBag
        string url="www.transflower.in";
        var product =new Product { Id=23,Title="Rose"};
        ViewBag.product=product;
        ViewBag.Website= url;
        ViewBag.School="Transflower school";
        ViewBag.age =35;
        return View();
    }

     public IActionResult Services()
    {
        //Using TempData
        string service ="Transforming Digital India";
        TempData["vision"]=service;
        return View();
    }
     public IActionResult SalesView()
    {
        SalesRepository list = new SalesRepository();
        ViewBag.Message="Transflower Sales!";
        return View();
    }
    
     public IActionResult Student()
    {
        List<string> data = new List<string>();
        data.Add("Pragati");
        data.Add("Akash");
        data.Add("Mayur");
        data.Add("Nutan");
        data.Add("Pooja");
        data.Add("Shivansh0");
        var result = data.ToArray();

        return new JsonResult(result);
    }

     public IActionResult List()
    {
        SalesRepository repository = new SalesRepository();

        return new JsonResult(repository.products);
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
