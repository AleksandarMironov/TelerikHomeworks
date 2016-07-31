using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AnimalHierarchy
{
    class Tomcat : Cat
    {
        public override void ProduceSound()
        {
            Console.WriteLine("May! I'm a Tomcat!");
        }

        public Tomcat (int age, string name):base(age, name, GenderTypes.Male)
        {

        }
    }
}
