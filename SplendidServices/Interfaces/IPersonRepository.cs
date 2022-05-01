using SplendidServices.Models;
namespace SplendidServices.Interfaces;
public interface IPersonRepository {
IQueryable<Person> GetAllActivePeople();
}