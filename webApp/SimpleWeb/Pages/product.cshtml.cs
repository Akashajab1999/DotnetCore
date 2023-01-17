using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWeb.Pages;

public class productModel : PageModel
{
    private readonly ILogger<productModel> _logger;

    public productModel(ILogger<productModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
