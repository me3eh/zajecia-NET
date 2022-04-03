#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeapYear.Data;
using LeapYear.Models;

namespace LeapYear.Pages.Person
{
    public class DetailsModel : PageModel
    {
        private readonly LeapYear.Data.LeapYearContext _context;

        public DetailsModel(LeapYear.Data.LeapYearContext context)
        {
            _context = context;
        }

        public LeapYearComponent LeapYearComponent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LeapYearComponent = await _context.Person.FirstOrDefaultAsync(m => m.Id == id);

            if (LeapYearComponent == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
