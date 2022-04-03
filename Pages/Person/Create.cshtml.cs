#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LeapYear.Data;
using LeapYear.Models;

namespace LeapYear.Pages.Person
{
    public class CreateModel : PageModel
    {
        private readonly LeapYear.Data.LeapYearContext _context;

        public CreateModel(LeapYear.Data.LeapYearContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LeapYearComponent LeapYearComponent { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Person.Add(LeapYearComponent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
