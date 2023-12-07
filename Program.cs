using Microsoft.EntityFrameworkCore;
using ProjetoFinalCaroline.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Data Source=SB-1490624\\SQLSENAI;Initial Catalog = ProjetoFinalCaroline;Integrated Security = True;TrustServerCertificate = True"));

/*builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Data Source=CAROL\\SQLSERVER2022;Initial Catalog = ProjetoFinalCaroline;Integrated Security = True;TrustServerCertificate = True"));*/

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
    pattern: "{controller=Usuario}/{action=Login}");

app.Run();
