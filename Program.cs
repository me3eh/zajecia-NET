using LeapYear.Data;
using Microsoft.EntityFrameworkCore;
using LeapYear.Interfaces;
using LeapYear.Services;
using LeapYear.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers();

builder.Services.AddTransient<ILeapYearRepository, LeapYearRepository>();
builder.Services.AddTransient<ILeapYearService, LeapYearService>();

builder.Services.AddDbContext<LeapYearContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("nowa")));

builder.Services.AddMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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

app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();
