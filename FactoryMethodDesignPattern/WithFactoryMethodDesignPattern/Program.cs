// See https://aka.ms/new-console-template for more information
using WithFactoryMethodDesignPattern;

Console.WriteLine("Hello, World!");
string cardType = "Platinum";

ICreditCard card = CreditCardFactory.GetCreditCard(cardType);

Console.WriteLine($"The card type is : {card.GetCardType()} \n Annual charges : {card.GetAnnualCharge()} \n Limit : {card.GetCreditLimit()}");

Console.ReadLine();