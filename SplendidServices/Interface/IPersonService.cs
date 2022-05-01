using SplendidServices.Models;

namespace SplendidServices.Interface;

public interface IPersonService {
    public IQueryable<Person> GetActivePeople();
}