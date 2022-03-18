using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzz.Models;
using Newtonsoft.Json;

namespace FizzBuzz.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public FizzBuzzModel FizzBuzz {get; set;}
    
    [BindProperty(SupportsGet = true)]
    public String? Name {get; set;}

    [BindProperty(SupportsGet = true)]
    public String? Number {get; set;}

    [BindProperty(SupportsGet = true)]
    public String? Success {get; set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
    public IActionResult OnPost()
    {
        if (ModelState.IsValid){
            HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(FizzBuzz));
            return RedirectToPage("./SavedInSession");
        }
        return Page();
    }
}
