﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SplendidServices.Data;
using SplendidServices.Models;

namespace SplendidServices.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
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