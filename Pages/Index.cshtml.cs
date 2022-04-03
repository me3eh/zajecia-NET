using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LeapYear.Models;
using LeapYear.Data;

using System.Collections;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace LeapYear.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly LeapYearContext _context;

    [BindProperty]
    public LeapYearComponent LeapYear {get; set;}
    
    public String SuccessMessage {get; set;}
    public ArrayList arrayWithInformationsAboutLeapYear {get; set;}

    public IList<LeapYearComponent> LeapYearPeople { get; set; }

    public IndexModel(ILogger<IndexModel> logger, LeapYearContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {

    }
    public IActionResult OnPost()
    {
        // LeapYearPeople = _context.LeapYearComponent.ToList();
        if (ModelState.IsValid){
            var Data = HttpContext.Session.GetString("SessionVariable1");
            if (Data != null){
                arrayWithInformationsAboutLeapYear = JsonConvert.DeserializeObject<ArrayList>(Data);
            }
            else
                arrayWithInformationsAboutLeapYear = new ArrayList();
            SuccessMessage = $"{LeapYear.Name} {LeapYear.LastName} urodził się w {LeapYear.Year} roku. To był rok {LeapYear.isYearLeapYear()} .";
                
            var stringToCache = $"{arrayWithInformationsAboutLeapYear.Count}. {LeapYear.Name} {LeapYear.LastName}, {LeapYear.Year} - rok {LeapYear.isYearLeapYear() }";

            arrayWithInformationsAboutLeapYear.Insert(0, stringToCache);
            HttpContext.Session.SetString("SessionVariable1", JsonConvert.SerializeObject(arrayWithInformationsAboutLeapYear));

            //zapis do bazy danych 
            LeapYear.Outcome = SuccessMessage;
            LeapYear.TimeOfWrite = DateTime.Now;
            _context.Person.Add(LeapYear);
            _context.SaveChanges();
            return Page();
        }
        return Page();
    }
}