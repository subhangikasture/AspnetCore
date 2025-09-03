// See https://aka.ms/new-console-template for more information
using WithStrategyDesignPattern;

Console.WriteLine("Hello, World!");

PaymentProcessor pp = new PaymentProcessor();
pp.SetPaymentStrategy(new CreditCardPayment());
pp.ProcessPayment(10000);
