using System;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorHosted.Client.Shared
{
    public class PersonDetailViewModel : BlazorComponent
    {
        [Parameter]
        protected User Person { get; set; }

        [Parameter]
        public Action<User> PersonSelected { get; set; }

        protected void SelectPerson()
        {
            Console.WriteLine("Handler called");
            PersonSelected?.Invoke(Person);
        }

    }
}
