// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int number1 = 10;
int number2;

AddFive(ref number1); // 15
Console.WriteLine($"number1 is {number1}");

GetRandomNumber(out number2);
Console.WriteLine($"Number2 is {number2}");
List<int> list = new List<int> {1,2 };

TestList(list);
foreach(var val in list)
{
    Console.WriteLine(val);
}
static void AddFive(ref int x)
{
    x = x + 5;
}
static void GetRandomNumber(out int y)
{
    y = new Random().Next(1, 100);
}
static void TestList(List<int> list)
{
    list[0] = 9;
    list[1] = 10;
}