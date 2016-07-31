using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AnimalHierarchy
{
    public abstract class Animals : ISound
    {
        private int age;
        private string name;
        private GenderTypes gender;

        public int Age
        {
            get
            {
                return this.age;
                
            }
            set
            {
                if (value<0)
                {
                    throw new ArithmeticException("Age is only positive!");
                }
                this.age  = value;
            }
        }

        public string Name {
            get
            {
                return this.name;
                
            }
           private set
            {
                if (value.Length<2)
                {
                    throw new ArithmeticException("Name must be atleast 2 characters");
                }
                this.name  = value;
            }
        }

        public GenderTypes Gender {
            get
            {
                return this.gender;
                
            }
            private set
            {
                //if ()  //to do
                //{
                //    throw new ArithmeticException("Male, female ot other!");
                //}
                this.gender  = value;
            }
        }



        public abstract void ProduceSound();

        public Animals(int age, string name, GenderTypes gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }


        public override string ToString()
        {
            string output = $"Hi! I'm {this.Name}. I'm {this.Age} years old. My gender is {this.Gender}";
            return output;
        }
    }
}
