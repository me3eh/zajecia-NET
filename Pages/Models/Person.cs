namespace EFDemo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Person {
public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    [Column(TypeName="varchar(100)")]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    
}