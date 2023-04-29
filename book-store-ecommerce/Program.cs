using book_store_ecommerce.Data;
using book_store_ecommerce.Data.Cart;
using book_store_ecommerce.Data.Services;
using book_store_ecommerce.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
String connString = builder.Configuration.GetConnectionString("DefaultConnectionString");

//Services configuration
builder.Services.AddScoped<IWritersService, WritersService>();//once per scope
builder.Services.AddScoped<IPublishingHousesService, PublishingHousesService>();
builder.Services.AddScoped<IProvidersService, ProvidersService>();
builder.Services.AddScoped<IBooksService, BooksService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //added singleton service
builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));
builder.Services.AddScoped<IOrdersService, OrdersService>();

//Authentification and authorization
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});
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
app.UseSession();

//Authentification & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Seed database
AppDbInitializer.Seed(app);
AppDbInitializer.SeedUsersAndRolesAsync(app).Wait();



app.Run();
