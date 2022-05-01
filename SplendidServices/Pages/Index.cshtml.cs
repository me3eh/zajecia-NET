using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SplendidServices.Data;
using SplendidServices.Models;
using SplendidServices.Interface;
using SplendidServices.Services;

namespace SplendidServices.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly PeopleContext _context;
    public IList<Person> People { get; set; }
    private readonly IPersonService _personService;
    public IQueryable<Person> Records { get; set; }
    public IndexModel(ILogger<IndexModel> logger, PeopleContext context, IPersonService personService)
    {
        _logger = logger;
        _context = context;
        _personService = personService;
    }

    public void OnGet()
    {
        People = _context.Person.ToList();
        Records = _personService.GetActivePeople();
    }
    [BindProperty]
    public Person Person { get; set; }
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
