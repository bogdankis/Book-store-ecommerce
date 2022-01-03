using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
String connString = builder.Configuration.GetConnectionString("DefaultConnectionString");

//Services configuration
builder.Services.AddScoped<IWritersService, WritersService>();//once per scope
builder.Services.AddScoped<IPublishingHousesService, PublishingHousesService>();
builder.Services.AddScoped<IProvidersService, ProvidersService>();
// Add services to the container.
//
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connString));
builder.Services.AddControllersWithViews();

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

//Seed database
AppDbInitializer.Seed(app);



app.Run();
