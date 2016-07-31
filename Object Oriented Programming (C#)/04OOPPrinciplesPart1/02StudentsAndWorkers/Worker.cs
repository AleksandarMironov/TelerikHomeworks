using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StudentsAndWorkers
{
    public class Worker:Humen
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary; 
                
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary must be positive number!");
                }
                this.weekSalary = value; 
                
            }
        }

        public decimal WorkHoursPerDay {
            get
            {
                return this.workHoursPerDay;

            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours must have positive value!");
                }
                this.workHoursPerDay = value;

            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;

        }

        public decimal MoneyPerHour()
        {
            decimal money = 0;
            money = this.WeekSalary / 5 / this.WorkHoursPerDay;
            return money;
        }

        public override string ToString()
        {
            string money =String.Format("{0:0.00}", this.MoneyPerHour());
            return base.ToString() + Environment.NewLine + "I'm earning " + money + " per hour! :)";
        }
    }
}
