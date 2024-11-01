using _72220591_UTS.Client;
using _72220591_UTS.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

builder.Services.AddScoped<CourseService>();
builder.Services.AddHttpClient<CourseService>(client =>
{
    client.BaseAddress = new Uri("https://actualbackendapp.azurewebsites.net/swagger/index.html");
});

