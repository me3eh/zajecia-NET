namespace SplendidServices.Repositories;
using SplendidServices.Models;
using SplendidServices.Interfaces;
using SplendidServices.Data;
public class PersonRepository : IPersonRepository
{
    private readonly PeopleContext _context;
    public PersonRepository(PeopleContext context) {
        _context = context;
    }
    public IQueryable<Person> GetAllActivePeople()
    {
        return _context.Person.Where(p => p.IsActive);
    }
}