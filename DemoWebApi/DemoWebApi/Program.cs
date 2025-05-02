using System;
using DemoWebApi.Controllers;
using DemoWebApi.Repository;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IEmplolyeeBuisenesslogic, EmployeeBuisenesslogic>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); 
    app.UseSwaggerUI();
}

app.Use(async(context, next) =>
{
    try
    {
        await next();
    }
    catch(Exception ex)
    {
        context.Response.StatusCode = 500;//500 Internal server error 
        await  context.Response.WriteAsync("hellooooo");
    }
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
