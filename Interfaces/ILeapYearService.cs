namespace LeapYear.Interfaces;
using LeapYear.Models;
using LeapYear.ViewModels;

public interface ILeapYearService {
    string AddEntry(LeapYearComponent leapYearComponent);
    ListLeapYearForListVM GetAllEntries();
    ListLeapYearForListVM GetEntriesFromToday();

    // IQueryable<LeapYearComponent> GetEntriesFromToday();

}