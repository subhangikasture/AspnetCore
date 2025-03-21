using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); /// Add MVC services
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>(); // Add scoped service for ICategoryRepository
builder.Services.AddScoped<IPieRepository, MockPieRepository>(); // Add scoped service for IPieRepository

var app = builder.Build();

app.UseStaticFiles();   //Use static files e.g. css, js, images

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //Use developer exception page when working on development environment
}

app.MapDefaultControllerRoute();  // Map default controller route

app.Run();
