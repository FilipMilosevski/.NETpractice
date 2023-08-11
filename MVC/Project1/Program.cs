using Microsoft.EntityFrameworkCore;
using Project1.Data;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ??  throw new InvalidOperationException("Connection string 'DefaultConnection' not found."); ;
builder.Services.AddDbContext<Project1DbContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Start}/{action=Index}");


app.Run();
