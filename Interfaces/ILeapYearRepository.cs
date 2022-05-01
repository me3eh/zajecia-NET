namespace LeapYear.Interfaces;
using LeapYear.Models;

public interface ILeapYearRepository{
    void addToDatabase(LeapYearComponent leapYear);
    List<LeapYearComponent> getAll();
    List<LeapYearComponent> GetEntriesFromToday();
}