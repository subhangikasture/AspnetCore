using System;
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); /// Add MVC services
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
var app = builder.Build();

app.UseStaticFiles();   //Use static files e.g. css, js, images
app.UseSession();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //Use developer exception page when working on development environment
}

app.MapDefaultControllerRoute();  // Map default controller route => "{Controller = Home}/{action = Index}/{id?}"

 DbInitializer.Seed(app); 

app.Run();
