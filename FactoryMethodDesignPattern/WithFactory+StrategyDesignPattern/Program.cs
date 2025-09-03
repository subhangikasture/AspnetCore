// See https://aka.ms/new-console-template for more information
using WithFactory_StrategyDesignPattern;

Console.WriteLine("Hello, World!");

PaymentStrategyFactory factory = new PaymentStrategyFactory();
IPaymentStrategy paymentStrategy = factory.CreatePaymentStrategy("CreditCard");

PaymentProcess pp = new PaymentProcess();
pp.SetPaymentStrategy(paymentStrategy);
pp.ProcessPayment(1000000);
