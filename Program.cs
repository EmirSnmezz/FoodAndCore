using FoodAndCore.Models;
using FoodAndCore.Models.Generic_Repository.Concrete;
using FoodAndCore.Models.Repositories.Abstract;
using FoodAndCore.Models.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<Context, Context>();
builder.Services.AddSingleton<IFoodRepository, FoodRepository>();
builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

//app.UseMvc
//    (
//    routes =>
//    {
//        routes.MapRoute
//        (
//            name: "default",
//            template: "{controller=Category}/{action=Index}/{id?}"
//        );


//    }
//    );

app.Run();
