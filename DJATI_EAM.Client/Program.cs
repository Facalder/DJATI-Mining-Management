using DJATI_EAM.Client.Services.Asset;
using DJATI_EAM.Shared.Interfaces;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

builder.Services.AddScoped<IAssetRepository, AssetService>();

await builder.Build().RunAsync();