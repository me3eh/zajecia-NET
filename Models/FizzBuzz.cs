using System.ComponentModel.DataAnnotations;
namespace FizzBuzz.Models
{
    public class FizzBuzzModel
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        
        [Required(ErrorMessage="Pole jest obowiązkowe"), 
        Range(1, 1000, ErrorMessage = "Oczekiwana wartość{0} z zakredu {1} i {2}.")]

        public int? Number { get; set; }
    }
}