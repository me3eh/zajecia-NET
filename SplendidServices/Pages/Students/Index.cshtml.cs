#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SplendidServices.Data;
using SplendidServices.Models;

namespace SplendidServices.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SplendidServices.Data.PeopleContext _context;

        public IndexModel(SplendidServices.Data.PeopleContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
