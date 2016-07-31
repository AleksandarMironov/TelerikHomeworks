using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AnimalHierarchy
{
    class Dog : Animals
    {
        public override void ProduceSound()
        {
            Console.WriteLine("BAY! I'm a Dog!");
        }

        public Dog(int age, string name, GenderTypes gender):base(age, name, gender)
        {

        }
    }
}
