using Microsoft.EntityFrameworkCore;
using WebAppFerreteria.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews();

//Middleware
builder.Services.AddHttpContextAccessor();

// Agrega la configuraci�n del DbContext con la cadena de conexi�n
builder.Services.AddDbContext<FerreteriaDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("FerreteriaDbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
