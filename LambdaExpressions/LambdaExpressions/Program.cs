using System.Security.Cryptography.X509Certificates;

namespace LambdaExpressions
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Subhangi",
                    Subject = "English"
                },

                new Student
                {
                    Id=2,
                    Name= "Mohit",
                    Subject = "Kannnad"

                },
                new Student
                {
                    Id=3,
                    Name= "Mohit k",
                    Subject = "Kannnad"

                },
                 new Student
                {
                    Id=4,
                    Name= "Mohit k m",
                    Subject = "Kannnad"

                }

            };

            var student = students
                .GroupBy(student => student.Subject)
                .Select(g =>
                new
                {
                      sub = g.Key,
                      count = g.Count()
                }).ToList();

            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine(student[i].sub + student[i].count);
            }

          //  var std = students.Select(student1 => new { student1.Subject ,student.Count });
            foreach(var val in student)
            {
                Console.WriteLine($"{val.sub}, {val.count}" );
            }



            /* List<int> even = new List<int>();
             List<int> numbers = new List<int>();
             foreach (int num in numbers)
             {
                 if (num % 2 == 0)
                     even.Add(num);
             }
              even = numbers.Where(n => n % 2 == 0).ToList();

             */

            Console.WriteLine("Hello, World!");
        }
    }
}
