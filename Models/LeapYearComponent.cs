using System.ComponentModel.DataAnnotations;
namespace LeapYear.Models
{
    public class LeapYearComponent
    {
        public int Id { get; set; }

        [Display(Name = "Rok urodzenia")]
        [Required(ErrorMessage="Pole {0} jest wymagane"), 
        Range(1899, 2022, ErrorMessage = "Oczekiwana wartość{0} z zakredu {1} i {2}.")]
        public int? Year { get; set; }
        
        [Display(Name = "Imię delikwenta")]
        [Required(ErrorMessage="Pole {0} jest wymagane"), 
        StringLength(10, ErrorMessage = "{0} wartość nie może przekraczać {1} znaków. ")]  
        public String? Name { get; set; }

        [Display(Name = "Nazwisko delikwenta")]
        [Required(ErrorMessage="Pole {0} jest wymagane"), 
        StringLength(10, ErrorMessage = "{0} wartość nie może przekraczać {1} znaków. ")]  
        public String? LastName { get; set; }

        [Display(Name = "Czas utworzenia")]
        public DateTime? TimeOfWrite { get; set; }

        [Display(Name = "Wynik")]
        public String? Outcome { get; set; }
        
        public bool isActive { get; set; }
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