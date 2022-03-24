using System.ComponentModel.DataAnnotations;
namespace LeapYear.Models
{
    public class LeapYearComponent
    {
        [Display(Name = "Rok urodzenia")]
        
        [Required(ErrorMessage="Pole jest wymagane"), 
        Range(1899, 2022, ErrorMessage = "Oczekiwana wartość{0} z zakredu {1} i {2}.")]

        public int? Year { get; set; }
        
        [Display(Name = "Imię delikwenta")]
        [Required(ErrorMessage="Pole jest wymagane"), 
        StringLength(10, ErrorMessage = "{0} wartość nie może przekraczać {1} znaków. ")]  

        public String? Name { get; set; }

        public String isYearLeapYear()
        {
            if( Year % 400 == 0 )
                return "przestępny";
            else if( Year % 100 == 0 )
                return "nieprzestępny";
            else if( Year % 4 == 0 )
                return "przestępny";
            else 
                return "nieprzestępny";
        }
    }
}