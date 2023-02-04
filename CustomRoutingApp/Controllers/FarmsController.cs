using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomRoutingApp.Models;

namespace CustomRoutingApp.Controllers;

public class FarmsController    : Controller
{
    private readonly ILogger<FarmsController  > _logger;

    public FarmsController  (ILogger<FarmsController  > logger)
    {
        _logger = logger;
    }

    
     public IActionResult GreenHouseDetails(string farmName,string unitNo,string CropName)
    {
        Console.WriteLine("Farm Name="+farmName + " GreenHouse Name="+unitNo +" Crop Name="+CropName );
        return View();
    }
    public IActionResult CropDetails(string farmName,string unitNo,string CropName)
    {
        Console.WriteLine("Farm Name="+farmName + " GreenHouse Name="+unitNo +" Crop Name="+CropName );
        return View();
    }
    public IActionResult CropDateDetails(string farmName,string unitNo,string CropName,string CropDate)
    {
        Console.WriteLine("FarmName="+farmName + "GreenHouse Name="+unitNo +"Crop Name="+CropName +"Crop Date="+CropDate);
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
