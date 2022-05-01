using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LeapYear.Models;
using LeapYear.Data;
using LeapYear.Interfaces;
using LeapYear.ViewModels;

namespace LeapYear.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly LeapYearContext _context;
    private readonly ILeapYearService _leapYearService;

    [BindProperty]
    public LeapYearComponent LeapYear {get; set;}
    
    public String SuccessMessage {get; set;}
    // public ArrayList arrayWithInformationsAboutLeapYear {get; set;}

    public ListLeapYearForListVM LeapYearPeople { get; set; }

    public IndexModel(ILogger<IndexModel> logger, LeapYearContext context, ILeapYearService leapYearInterface)
    {
        _logger = logger;
        _context = context;
        _leapYearService = leapYearInterface;
    }

    public void OnGet()
    {
        LeapYearPeople = _leapYearService.GetEntriesFromToday();
    }
    public IActionResult OnPost()
    {
        // LeapYearPeople = _context.LeapYearComponent.ToList();
        if (ModelState.IsValid){
            // var Data = HttpContext.Session.GetString("SessionVariable1");
            // if (Data != null){
            //     arrayWithInformationsAboutLeapYear = JsonConvert.DeserializeObject<ArrayList>(Data);
            // }
            // else
            //     arrayWithInformationsAboutLeapYear = new ArrayList();
                
            // var stringToCache = $"{arrayWithInformationsAboutLeapYear.Count}. {LeapYear.Name} {LeapYear.LastName}, {LeapYear.Year} - rok {LeapYear.isYearLeapYear() }";

            // arrayWithInformationsAboutLeapYear.Insert(0, stringToCache);
            // HttpContext.Session.SetString("SessionVariable1", JsonConvert.SerializeObject(arrayWithInformationsAboutLeapYear));

            //zapis do bazy danych

            SuccessMessage = _leapYearService.AddEntry(LeapYear);
            // LeapYear.Outcome = SuccessMessage;
            // LeapYear.TimeOfWrite = DateTime.Now;
            // _context.Person.Add(LeapYear);
            // _context.SaveChanges();
            return Page();
        }
        return Page();
    }
}