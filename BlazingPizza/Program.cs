using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazingPizza;
using BlazingPizza.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Configure logging
builder.Logging.SetMinimumLevel(LogLevel.Debug);

// Add root components
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure HTTP client
builder.Services.AddScoped(sp => new HttpClient { 
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});

// Register services
builder.Services.AddScoped<PizzaService>();

try
{
    var host = builder.Build();
    
    // Log startup information
    var logger = host.Services.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Application starting...");
    
    await host.RunAsync();
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Application startup error: {ex}");
    throw;
}
