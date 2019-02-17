using System;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorHosted.Client.Shared
{
    public class PersonDetailViewModel : ComponentBase
    {
        [Parameter]
        protected User Person { get; set; }

        [Parameter]
        internal Action<User> PersonSelected { get; set; }

        protected void SelectPerson()
        {
            Console.WriteLine("Handler called");
            PersonSelected?.Invoke(Person);
        }

    }
}
