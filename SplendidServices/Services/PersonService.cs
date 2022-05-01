namespace SplendidServices.Services;
using SplendidServices.Interface;
using SplendidServices.Models;
using SplendidServices.Data;
public class PersonService : IPersonService {
    private readonly PeopleContext _context;
    public PersonService(PeopleContext context) {
        _context = context;
    }
    public IQueryable<Person> GetActivePeople() {
        return _context.Person.Where(p => p.IsActive);
    }
}
