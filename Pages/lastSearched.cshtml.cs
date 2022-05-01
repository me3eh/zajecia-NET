using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using LeapYear.Data;
using LeapYear.ViewModels;
using LeapYear.Interfaces;
using LeapYear.ViewModels;
namespace LeapYear.Pages
{
    public class lastSearchedModel : PageModel
    {
        private readonly ILeapYearService _leapYearService;
        private readonly LeapYearContext _context;
        
        [BindProperty]
        public ListLeapYearForListVM LeapYearPeople { get; set; }

        public lastSearchedModel(LeapYearContext context, ILeapYearService leapYearService)
        {
            _context = context;
            _leapYearService = leapYearService;
        }
        public void OnGet()
        {
            LeapYearPeople = _leapYearService.GetAllEntries();
            // LeapYearPeople = _context.Person.OrderByDescending(x => x.TimeOfWrite).Take(20).ToList();
        }
    }
}
