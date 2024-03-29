﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using DemoApp.Models;
using DemoApp.Helpers;

namespace DemoApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    private readonly IConfiguration _configuration;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _configuration=_configuration;
    }

    public IActionResult Index()
    {
        //Will store string ,integer and complex object in to
        //session maintained inside distributed cache
        //at server side

        string SessionName="product";
        string SessionKeyAge="age";
        HttpContext.Session.SetString(SessionName,"Dell computer");
        HttpContext.Session.SetString(SessionKeyAge,45);
        Cart theCart=SessionHelper.GetObjectFroomJson<Cart>(HttpContext.Session,"cart");
        if (theCart==null){
            theCart=new Cart();
            SessionHelper.SetObjectAsJson(HttpContext.Session,"cart",theCart);
        }
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.data =HttpContext.Session.GetString("product");
        ViewBag.age=HttpContext.Session.GetInt32("age");
        Cart theCart =SessionHelper.GetObjectFroomJson<Cart>(HttpContext.Session,"cart");
        ViewData["cart"]=theCart;
        return View();
    }

   public IActionResult Connect(){
            string conString=string.Empty;
            //get connections strings from appsettings.json file
            var connection = _configuration.GetValue<string>("ConnectionStrings:ConnectionStringActsDB");
            var connection1 = _configuration.GetSection("ConnectionStrings").GetSection("ConnectionStringActsDB").Value;
            var connection2 = _configuration["ConnectionStrings:ConnectionStringActsDB"];
            var connection3 = _configuration.GetConnectionString("ConnectionStringActsDB");

            List<string> connectionStrings=new List<string>();
            connectionStrings.Add(connection);
            connectionStrings.Add(connection1);
            connectionStrings.Add(connection2);
            connectionStrings.Add(connection3);
            //Initializing connection string
            ViewData["connectionStrings"]=connectionStrings;
            return View();
        }

        public IActionResult QueryTest(){
            string city=string.Empty;
            string state=string.Empty;
            string name=string.Empty;
            name=HttpContext.Request.Query["name"];
            city=HttpContext.Request.Query["city"];
            state=HttpContext.Request.Query["state"];
            return Content("Query Test funcation is invoked...." + name + "  " + city + " "+ state );
        }

        public IActionResult  Students(){
            List<string> data=new List<string>();
            data.Add("Ravi");
            data.Add("Sameer");
            data.Add("Rajiv");
            data.Add("Pramod");
            var result=data.ToArray();
            return new JsonResult(result);
        } 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
