using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AnimalHierarchy
{
    class StartMeFromHere
    {
        static void Main(string[] args)
            ///i should arange classes in some folders, but.......
        {
            List<Animals> list = new List<Animals>();
            list.Add(new Dog(10, "Sharo", GenderTypes.Male));
            list.Add(new Cat(11, "Maca", GenderTypes.Female));
            list.Add(new Frog(7, "Kircho", GenderTypes.Male));
            list.Add(new Kitten(3, "Tom"));
            list.Add(new Tomcat(2, "Lola"));
            list.Add(new Dog(18, "Murdjo", GenderTypes.Male));
            list.Add(new Cat(1, "Nala", GenderTypes.Female));
            list.Add(new Frog(2, "Princess", GenderTypes.Female));

            foreach (var animal in list)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine("-----------------------");

            double avarageAge = 1.00 * list.Sum(x => x.Age) / list.Count;
            Console.WriteLine("Avarage age: " + avarageAge);
        }
    }
}
