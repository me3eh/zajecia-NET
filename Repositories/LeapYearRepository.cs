namespace LeapYear.Repositories;
// using LeapYear.Models;
using System.ComponentModel.DataAnnotations;
using LeapYear.Data;
using LeapYear.Interfaces;
using LeapYear.Models;

public class LeapYearRepository : ILeapYearRepository {
    private readonly LeapYearContext _context;
    public LeapYearRepository(LeapYearContext context) {
        _context = context;
    }
    public void addToDatabase(LeapYearComponent leapYear){
        _context.Person.Add(leapYear);
        _context.SaveChanges();
    }
    public List<LeapYearComponent> getAll()
    {
        return _context.Person.OrderByDescending(x => x.TimeOfWrite).Take(20).ToList();
    }

    public List<LeapYearComponent> GetEntriesFromToday()
    {
        // Console.WriteLine(_context.Person.First.TimeOfWrite.Day);
        return _context.Person.Where(x => x.TimeOfWrite.Value.Day == DateTime.Now.Day &&
                                            x.TimeOfWrite.Value.Month == DateTime.Now.Month &&
                                            x.TimeOfWrite.Value.Year == DateTime.Now.Year).OrderByDescending(x => x.TimeOfWrite).Take(20).ToList();
    }
}