// See https://aka.ms/new-console-template for more information
using StrategyDesignPattern;

Console.WriteLine("Hello, World!");
PaymentProcessor p = new PaymentProcessor();

p.ProcessPayment("CreditCard", 100000);