using FoodAndCore.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<Context, Context>();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
