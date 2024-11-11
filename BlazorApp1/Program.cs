using BlazorApp1.DataConsumers;
using BlazorApp1.HttpClientServices;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddOptions();

            // Register the StudentConsumer
            builder.Services.AddTransient<StudentConsumer>();

            // Set up HttpClient for the API service using configuration
            builder.Services.AddHttpClient<APIService>(client =>
            {
                // Use the base address from the configuration
                client.BaseAddress = new Uri(builder.Configuration["APIAddress"]);
            });

            // Register a scoped HttpClient for general use (like calling other APIs)
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // Build the host
            var host = builder.Build();
           // Or any other logging provider

            // Optionally, set up JavaScript interop if needed
            var jsInterop = host.Services.GetRequiredService<IJSRuntime>();

            // Run the application
            await host.RunAsync();
        }
    }
}
