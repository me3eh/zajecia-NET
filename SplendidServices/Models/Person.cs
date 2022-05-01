using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplendidServices.Models;

public class Person {
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    [Column(TypeName="varchar(100)")]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    public bool IsActive { get; set; }
    public virtual ICollection<Address>? Addresses { get; set; }
    public ICollection<PersonGroup>? PersonGroups { get; set; }
}