using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorHosted.Client.Services
{
    public class DomainService : IDomainService
    {
        private readonly HttpClient _httpClient;


        public List<User> AvailablePersons { get; private set; } = new List<User>();

        public DomainService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task LoadPersons()
        {
            var serviceResponse = await _httpClient.GetJsonAsync<List<User>>("api/persons");
            AvailablePersons = serviceResponse;

            await SaveList();
        }

        public async Task DeleteLastPerson()
        {
            AvailablePersons.RemoveAt(AvailablePersons.Count - 1);
            await SaveList();
        }

        public async Task SaveList()
        {
            // Nop
            await Task.CompletedTask;
        }
    }
}
