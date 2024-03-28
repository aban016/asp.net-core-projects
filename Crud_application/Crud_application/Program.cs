using Crud_application.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<myContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("myCon")));
var app = builder.Build();

app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.Run();
