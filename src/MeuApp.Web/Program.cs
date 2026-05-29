using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MeuApp.Web;
using MeuApp.Web.Features.Auth.Services;
using MeuApp.Web.Features.Atletas.Services;
using MeuApp.Web.Features.Chat.Services;
using MeuApp.Web.Features.Checkins.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<ChatService>();
builder.Services.AddScoped<CheckinService>();

builder.Services.AddScoped<AuthSessionService>();
builder.Services.AddScoped<AtletaService>();

await builder.Build().RunAsync();
