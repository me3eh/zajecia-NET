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
using System.Security.Claims;

namespace LeapYear.Pages.Person
{
    public class IndexModel : PageModel
    {
        private readonly LeapYear.Data.LeapYearContext _context;

        public IndexModel(LeapYear.Data.LeapYearContext context)
        {
            _context = context;
        }

        public IList<LeapYearComponent> LeapYearComponent { get;set; }

        public async Task OnGetAsync()
        {
            LeapYearComponent = await _context.Person.ToListAsync();
        }
    }
}
