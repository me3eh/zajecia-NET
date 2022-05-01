using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplendidServices.Models;

public class PersonGroup
{
    public int PersonId { get; set; } //klucz obcy do Person
    public Person Person { get; set; }
    public int GroupId { get; set; } //klucz obcy do Group
    public Group Group { get; set; }
}