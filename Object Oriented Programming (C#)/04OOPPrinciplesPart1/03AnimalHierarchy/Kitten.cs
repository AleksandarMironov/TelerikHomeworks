using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AnimalHierarchy
{
    class Kitten :Cat
    {
        public override void ProduceSound()
        {
            Console.WriteLine("May! I'm a Kitten!");
        }

        public Kitten(int age, string name):base(age, name, GenderTypes.Female)
        {

        }
    }
}
