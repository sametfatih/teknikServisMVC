using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using teknikServisMVC.Repositories;
using teknikServisMVC.Repositories.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<serviceDbContext>(options => options.UseSqlServer(@"Server=.\;Database=teknikservisDB;Trusted_Connection=True;TrustServerCertificate=True"));
builder.Services.AddScoped<ArizaDurumuRepository, ArizaDurumuRepository>();
builder.Services.AddScoped<ArizaRepository, ArizaRepository>();
builder.Services.AddScoped<MusteriRepository, MusteriRepository>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
