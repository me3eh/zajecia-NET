namespace LeapYear.Services;
using LeapYear.Models;
using LeapYear.Interfaces;
using LeapYear.ViewModels;
public class LeapYearService : ILeapYearService {
    private readonly ILeapYearRepository _leapYearRepository;
    public LeapYearService(ILeapYearRepository leapYearRepository){
        _leapYearRepository = leapYearRepository;
    }
    public string AddEntry(LeapYearComponent leapYear){
        string successMessage = $"{leapYear.Name} {leapYear.LastName} urodził się w {leapYear.Year} roku. To był rok {leapYear.isYearLeapYear()} .";
        leapYear.Outcome = successMessage;
        leapYear.TimeOfWrite = DateTime.Now;
        _leapYearRepository.addToDatabase(leapYear);
        return successMessage;
    }
    public ListLeapYearForListVM GetAllEntries(){
        var leapYearlist = _leapYearRepository.getAll();
        ListLeapYearForListVM result = new ListLeapYearForListVM();
        result.LeapYears = new List<LeapYearForListVM>();
        foreach (var person in leapYearlist) {
        // mapowanie obiektow
            var LPVM = new LeapYearForListVM()
            {
                Outcome = person.Outcome
            };
            result.LeapYears.Add(LPVM);
        }
        result.Count = result.LeapYears.Count;
        return result;
    }

    public ListLeapYearForListVM GetEntriesFromToday(){
        var leapYearlist = _leapYearRepository.GetEntriesFromToday();
        ListLeapYearForListVM result = new ListLeapYearForListVM();
        result.LeapYears = new List<LeapYearForListVM>();
        foreach (var person in leapYearlist) 
        {
            var LPVM = new LeapYearForListVM()
            {
                Outcome = person.Outcome
            };
            result.LeapYears.Add(LPVM);
        }
        result.Count = result.LeapYears.Count;
        return result;
    }

}