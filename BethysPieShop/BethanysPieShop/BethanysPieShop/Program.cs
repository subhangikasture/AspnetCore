using System;
using System.Text.Json.Serialization;
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BethanysPieShopDbContextConnection") ?? throw new InvalidOperationException("Connection string 'BethanysPieShopDbContextConnection' not found.");

builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    { 
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; 
    });/// Add MVC services

builder.Services.AddRazorPages(); // Add Razor Pages services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // Add Razor Components services



builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); // Add scoped service for ICategoryRepository
builder.Services.AddScoped<IPieRepository, PieRepository>(); // Add scoped service for IPieRepository
builder.Services.AddScoped<IOrderRepository, OrderRepository>();


builder.Services.AddScoped<IShoppingCart, ShopingCart>(sp => ShopingCart.GetCart(sp)); // Add scoped service for IShoppingCart
builder.Services.AddSession(); // Add session service
builder.Services.AddHttpContextAccessor();

// Configure DbContext with connection string
builder.Services.AddDbContext<BethanysPieShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]);
});

builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<BethanysPieShopDbContext>();

//Api creation for search
//builder.Services.AddControllers(); // Add API controllers, if yiu don't have builder.Services.AddControllersWithViews(); 

var app = builder.Build();

app.UseStaticFiles();   //Use static files e.g. css, js, images
app.UseSession();
app.UseAuthentication(); // Use authentication middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //Use developer exception page when working on development environment
}

app.MapDefaultControllerRoute();  // Map default controller route => "{Controller = Home}/{action = Index}/{id?}" 

app.UseAntiforgery();
//to create only api MapControllers you can add
app.MapRazorPages(); // Map Razor Pages

//app.MapRazorComponents<App>()
   // .AddInteractiveServerRenderMode(); // Map Razor Components
DbInitializer.Seed(app); 

app.Run();
