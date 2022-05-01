using Awesome.Net.WritableOptions.Extensions;
using Gatarr.Models.Settings;
using Gatarr.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();
builder.Services.AddAntDesign();

builder.Services.AddSingleton<IRadarrService, RadarrService>();
builder.Services.AddSingleton<ISonarrService, SonarrService>();

builder.Services.ConfigureWritableOptions<RadarrSettings>(builder.Configuration, "Radarr");
builder.Services.ConfigureWritableOptions<SonarrSettings>(builder.Configuration, "Sonarr");
builder.Services.ConfigureWritableOptions<LidarrSettings>(builder.Configuration, "Lidarr");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
