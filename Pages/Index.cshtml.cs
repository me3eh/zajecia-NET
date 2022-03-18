﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzz.Models;

namespace FizzBuzz.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public FizzBuzzModel FizzBuzz {get; set;}
    
    [BindProperty(SupportsGet = true)]
    public String? Name {get; set;}

    [BindProperty(SupportsGet = true)]
    public String? Number {get; set;}

    [BindProperty(SupportsGet = true)]
    public String? Success {get; set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
    public IActionResult OnPost()
    {
        if(!ModelState.IsValid){
            return Page();
        }
        else{
            if( FizzBuzz.Number % 3 == 0)
                Success += "Fizz";
            if( FizzBuzz.Number % 5 == 0)
                Success += "Buzz";
            if(string.IsNullOrEmpty(Success) )
                Success += "Liczba: " + FizzBuzz.Number + " nie spełnia kryteriów FizzBuzz"; 
            return Page();
        }
    }
}