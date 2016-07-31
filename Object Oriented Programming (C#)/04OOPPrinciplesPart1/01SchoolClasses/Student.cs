using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SchoolClasses
{
    public class Student : Person, IName, IComment
    {
        private int classNumber;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                Verification.CheckIfNumberNegative(value, "The class number cannot be negative number");
                this.classNumber = value;
            }
        }
    }
}
