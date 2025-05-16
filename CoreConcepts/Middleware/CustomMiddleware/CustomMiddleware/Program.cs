using CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseMiddleware<LoggerMiddleware>();
app.MapGet("/", () => "Hello World!");
app.Run();
