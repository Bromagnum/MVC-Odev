using Microsoft.EntityFrameworkCore;
using MVC_Antrenman.Models.Models;
using MVC_Antrenman.Repositories.Abstracts;
using MVC_Antrenman.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//DbConnection
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Dependency Injection Services
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

//DbContext
builder.Services.AddDbContext<NorthwndContext>(options => options.UseSqlServer(connectionString));

//RazorRuntime

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Area Route
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
