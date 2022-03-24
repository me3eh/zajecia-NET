using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LeapYear.Models;

using System.Collections;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace LeapYear.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    [BindProperty]
    public LeapYearComponent LeapYear {get; set;}
    
    public String SuccessMessage {get; set;}
    public ArrayList arrayWithInformationsAboutLeapYear {get; set;}

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
            var Data = HttpContext.Session.GetString("SessionVariable1");
            if (Data != null){
                arrayWithInformationsAboutLeapYear = JsonConvert.DeserializeObject<ArrayList>(Data);
            }
            else
                arrayWithInformationsAboutLeapYear = new ArrayList();
            SuccessMessage = LeapYear.Name + " urodził się w " + LeapYear.Year +
                " roku. To był rok " + LeapYear.isYearLeapYear() + ".";
                
            var stringToCache = arrayWithInformationsAboutLeapYear.Count + ". " + LeapYear.Name + "," + 
                LeapYear.Year + " - rok " + LeapYear.isYearLeapYear();

            arrayWithInformationsAboutLeapYear.Insert(0, stringToCache);
            HttpContext.Session.SetString("SessionVariable1", JsonConvert.SerializeObject(arrayWithInformationsAboutLeapYear));
        }
        return Page();
    }
}
