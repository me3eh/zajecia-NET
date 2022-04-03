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
    public class DeleteModel : PageModel
    {
        private readonly LeapYear.Data.LeapYearContext _context;

        public DeleteModel(LeapYear.Data.LeapYearContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LeapYearComponent = await _context.Person.FindAsync(id);

            if (LeapYearComponent != null)
            {
                _context.Person.Remove(LeapYearComponent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
