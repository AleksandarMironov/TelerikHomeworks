using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StudentsAndWorkers
{
    class Student : Humen
    {

        private double grade;

        public double Grade
        {
            get
            {
                return this.grade;
                
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade must be in 2-6 range!");
                }
                this.grade = value;
                
            }
        }

        public Student(string firstName, string secondName, double grade) : base(firstName, secondName)
        {
            this.Grade = grade;

        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "My grade is: " + this.Grade;
        }
    }
}
