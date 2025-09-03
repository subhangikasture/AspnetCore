using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Filtering with Where

            List<int> numbers = new List<int>{ 1,2,3,4, 5 , 6};
            //find even numbers 
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            for(int i = 0; i < evenNumbers.Count; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }
            Console.ReadLine();
        }
    }
}
