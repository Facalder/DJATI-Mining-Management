using DJATI_EAM.Components;
using DJATI_EAM.Model;
using DJATI_EAM.Shared.Interfaces;
using DJATI_EAM.Client.Services;

using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddMudServices();
builder.Services.AddServerSideBlazor();

// TSAS
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidDataException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<DJATIEAMDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IAssetRepository, AssetService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseAddress").Value!)
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapControllers();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(DJATI_EAM.Client._Imports).Assembly);

app.Run();
