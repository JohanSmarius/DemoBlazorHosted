using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorHosted.Shared;

namespace BlazorHosted.Client.Services
{
    public interface IDomainService
    {

        Task LoadPersons();
        List<User> AvailablePersons { get; }
        Task DeleteLastPerson();
        Task LoadSavedList();
    }
}
