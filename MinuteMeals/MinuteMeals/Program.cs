using Microsoft.EntityFrameworkCore;
using MinuteMeals.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<RecipeDbContext>(options =>
    options.UseInMemoryDatabase("RecipeDB"));

// Add services to the container.
builder.Services.AddControllersWithViews();
 

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<RecipeDbContext>();
    context.Database.EnsureCreated();
}


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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Recipes}/{action=Index}/{id?}");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Recipes}/{action=Index}/{id?}");

app.Run();
