using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using LeapYear.Data;
using LeapYear.Models;

namespace LeapYear.Pages
{
    public class lastSearchedModel : PageModel
    {
        private readonly LeapYearContext _context;
        public IList<LeapYearComponent> LeapYearPeople { get; set; }

        public lastSearchedModel(LeapYearContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            LeapYearPeople = _context.Person.OrderByDescending(x => x.TimeOfWrite).Take(20).ToList();
        }
    }
}
