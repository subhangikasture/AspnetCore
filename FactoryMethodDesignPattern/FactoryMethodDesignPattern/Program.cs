// See https://aka.ms/new-console-template for more information
using System.Net;
using FactoryMethodDesignPattern;

Console.WriteLine("Hello, World!");

string? type = Console.ReadLine();

ICreditCard card = null;
if(type.Equals("MoneyBack", StringComparison.OrdinalIgnoreCase))
{
    card = new MoneyBack();
}
else if(type.Equals("Platinum", StringComparison.OrdinalIgnoreCase))
{
    card = new Platinum();
}else if(type.Equals("Titanium", StringComparison.OrdinalIgnoreCase))
{
    card = new Platinum();
}

Console.WriteLine($"The card type is : {card.GetCardType()} \n Annual charges : {card.GetAnnualCharge()} \n Limit : {card.GetCreditLimit()}");

Console.ReadLine();