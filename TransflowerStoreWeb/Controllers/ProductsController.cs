using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TransflowerStoreWeb.Models;
using Catalog;

namespace TransflowerStoreWeb.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        List<Product> allProducts=Catalog.ProductManager.GetAllProducts();
        this.ViewData["products"]=allProducts;

        return View();
    }

    public IActionResult Details(int id)
    {
        Product product = ProductManager.Get(id);
        this.ViewData["product"]=product;
        return View();
    }

    [HttpGet]
     public IActionResult Insert(int id)
    {
        
        Console.WriteLine("Get Http insert Method is invoked before Empty send to client");
        return View();
    }

    [HttpPost]
     public IActionResult Insert(int Id,string Title,string Description,int unitPrice,int Quantity,string ImageUrl)
    {
        Product product = new Product(){
            Id=Id,
            Title=Title,
            Description=Description,
            ImageUrl=ImageUrl,
            Quantity=Quantity,
            UnitPrice=unitPrice


        };
        ProductManager.Insert(product);
        Console.WriteLine("Post Http insert method is invoked after form submission");
        return View();
    }
     

     [HttpGet]
      public IActionResult Update(int id)
    {
        
        Console.WriteLine("Get Http update Method is invoked before data send to client");
        return View();
    }


     [HttpPost]
      public IActionResult Update(Product modifiedProduct)
    {
        ProductManager.Update(modifiedProduct);
        Console.WriteLine("Post Http update Method is invoked after form submission");
        return RedirectToAction("Index","products");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
