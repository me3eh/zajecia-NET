using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SplendidServices.Data;
using SplendidServices.Models;
using SplendidServices.Interfaces;
using SplendidServices.ViewModels.Person;

namespace SplendidServices.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IPersonService _personService;
    public ListPersonForListVM Records { get; set; }
    private readonly PeopleContext _context;
    public IList<Person> People { get; set; }

    public IndexModel(ILogger<IndexModel> logger, PeopleContext context, IPersonService personService)
    {
        _logger = logger;
        _context = context;
        _personService = personService;

    }

    public void OnGet()
    {
        People = _context.Person.ToList();
        Records = _personService.GetPeopleForList();
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
