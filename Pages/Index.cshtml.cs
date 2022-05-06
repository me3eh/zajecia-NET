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
        if (ModelState.IsValid){
            SuccessMessage = _leapYearService.AddEntry(LeapYear);
            LeapYearPeople = _leapYearService.GetEntriesFromToday();
            return Page();
        }
        return Page();
    }
}