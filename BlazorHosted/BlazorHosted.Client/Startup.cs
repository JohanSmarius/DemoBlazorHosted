using BlazorHosted.Client.JavaScriptInterop;
using BlazorHosted.Client.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorHosted.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainService, DomainService>();
            services.AddScoped<IJavaScriptInterop, JavaScriptInterop.JavaScriptInterop>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
