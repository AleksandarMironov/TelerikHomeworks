using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StudentsAndWorkers
{
    class StartMeFromHere
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Balkan", "Ivanov", 6),
                new Student("Petur", "Petrov", 6),
                new Student("Aleksandar", "Dunov", 5),
                new Student("Cun", "Kai", 2),
                new Student("Random", "Name", 3),
                new Student("Gosho", "Petrov", 5.55),
                new Student("Pesho", "Ivanov", 4),
                new Student("Stamat", "Stamatov", 6),
                new Student("Gichka", "Michkova", 5),
                new Student("Petranka", "Hristova", 4.6),

            };

            List<Worker> workerList = new List<Worker>()
            {
                new Worker("Nqmam", "Ideq", 800,8),
                new Worker("Petka", "Marinov", 300,10),
                new Worker("Michka", "Hristova", 500,8),
                new Worker("Ginka", "Petkova", 1000,4),
                new Worker("Svetla", "Panova", 1500,5),
                new Worker("Desislava", "NoLastName", 800,9),
                new Worker("Kris", "Gacov", 950,8.5m),
                new Worker("Ivan", "Ivanov", 679,6.3m),
                new Worker("Ivancho", "Dimitrov", 900,8),
                new Worker("Svetlin", "Nakov", 2500,11),

            };



            var orderedStudents = studentList.OrderBy(x => x.Grade);
            Console.WriteLine("Students ordered by Grade: ");
            foreach (var stud in orderedStudents)
            {
                Console.WriteLine(stud + Environment.NewLine);
            }

            Console.WriteLine();

            Console.WriteLine("Workers ordered by MoneyPerHour: ");
            var sortedWorkers = workerList.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + Environment.NewLine);
            }


        }
    }
}
