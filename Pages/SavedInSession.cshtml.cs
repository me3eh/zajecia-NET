using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

using FizzBuzz.Models;

namespace FizzBuzz.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public FizzBuzzModel FizzBuzz { get; set; }
        
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzzModel>(Data);
        }
    }
}
