using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AnimalHierarchy
{
    class Frog : Animals
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Grouwr! I'm a Frog!");
        }

        public Frog(int age, string name, GenderTypes gender):base(age, name, gender)
        {

        }
    }
}
