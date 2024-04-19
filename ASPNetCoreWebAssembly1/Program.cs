using ASPNetCoreWebApi1.ApplicationLayer.Services;
using ASPNetCoreWebAssembly1;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NetcodeHub.Packages.Components.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7033/") });
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ToastService>();

await builder.Build().RunAsync();
