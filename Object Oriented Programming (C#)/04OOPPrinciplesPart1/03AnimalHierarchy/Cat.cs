using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AnimalHierarchy
{
    public class Cat :Animals
    {

        public override void ProduceSound()
        {
            Console.WriteLine("May! I'm a Cat!");
        }

        public Cat(int age, string name, GenderTypes gender):base(age, name, gender)
        {
            
        }
    }
}
