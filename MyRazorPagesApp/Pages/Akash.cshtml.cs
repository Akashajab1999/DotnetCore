using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorPagesApp.Pages;

public class AkashModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public AkashModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

