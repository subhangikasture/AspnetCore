// See https://aka.ms/new-console-template for more information
using Singleton;

Logger[] instances = new Logger[10];
Parallel.For(0, 10, i =>
{
    instances[i] = Logger.getLoggerInstance;
});

// Check how many unique instances were created
var unique = instances.Distinct().Count();
Console.WriteLine($"Unique instances created: {unique}");
Console.ReadLine();
