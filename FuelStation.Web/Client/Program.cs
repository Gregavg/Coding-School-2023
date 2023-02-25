using Blazored.SessionStorage;
using FuelStation.Web.Client;
using FuelStation.Web.Client.Authentication;
using FuelStation.Web.Client.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddBlazoredSessionStorage();///
builder.Services.AddScoped<AuthenticationStateProvider,CustomAuthenticationStateProvider>();///
builder.Services.AddSingleton<UserStatus>();///////////////////////////
builder.Services.AddAuthorizationCore();///



await builder.Build().RunAsync();
