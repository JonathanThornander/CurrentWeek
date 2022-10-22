using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Mindash.Countdown.Web.Data;
using Mindash.Countdown.Web.Services;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMudServices();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<CountDownDBContext>();
builder.Services.AddScoped<ICountDownService, CountDownService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
