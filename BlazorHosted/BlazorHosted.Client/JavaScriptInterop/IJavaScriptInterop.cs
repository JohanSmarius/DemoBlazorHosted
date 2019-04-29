using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHosted.Client.JavaScriptInterop
{
    public interface IJavaScriptInterop
    {
        Task<bool> Confirm(string message);
    }
}
