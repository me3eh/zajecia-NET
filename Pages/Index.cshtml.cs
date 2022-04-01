using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFDemo.Models;
using EFDemo.Data;

namespace EFDemo.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    [BindProperty]
    public Person Person { get; set; }

    private readonly PeopleContext _context;
    public IList<Person> People { get; set; }

    public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        People = _context.Person.ToList();
    }
    public IActionResult OnPost()
    {
        People = _context.Person.ToList();
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _context.Person.Add(Person);
        _context.SaveChanges();
        return RedirectToPage("./Index");
    }
}
