using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StudentsAndWorkers
{
    public abstract class Humen
    {
        private string firstName;
        private string lastName;


        public string FirstName
        {
            get
            {
                return this.firstName;

            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must be atleast 2 simbols!");
                }
                this.firstName = value;

            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;

            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must be atleast 2 simbols!");
                }
                this.lastName = value;
            }
        }

        public Humen(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return "My name is:" + FirstName + " " + LastName;
        }
    }
}
    