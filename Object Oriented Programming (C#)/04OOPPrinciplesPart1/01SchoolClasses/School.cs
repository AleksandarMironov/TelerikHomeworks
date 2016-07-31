using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SchoolClasses
{
    public class School
    {
        List<SchoolClass> classes;

        public School()
        {
            this.classes = new List<SchoolClass>();
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return new List<SchoolClass>(this.classes);
            }
            private set
            {
                this.classes = value;
            }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.Classes.Add(schoolClass);
        }

        public void RemoveClass(SchoolClass schoolClass)
        {
            this.Classes.Remove(schoolClass);
        }
    }
}
