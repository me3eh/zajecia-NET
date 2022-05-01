namespace SplendidServices.Interfaces;
using SplendidServices.ViewModels.Person;

public interface IPersonService {
    ListPersonForListVM GetPeopleForList();
}