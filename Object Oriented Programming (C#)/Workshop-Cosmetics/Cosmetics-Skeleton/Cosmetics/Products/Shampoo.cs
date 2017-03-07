using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cosmetics.Products
{
    public class Shampoo : Products, IShampoo, IProduct
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage):
            base(name, brand, price, gender)
        {
            
            this.Milliliters = milliliters;
            this.Usage = usage;

        }




        public uint Milliliters
        {
            get
            {
                return this.milliliters;
                
            }
            set
            {
                this.milliliters = value;
                
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
                
            }
            set
            {
                this.usage = value;
                
            }
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  * Quantity: " + this.Milliliters + " ml");
            sb.AppendLine("  * Usage: " + this.Usage);

            return base.Print() + sb.ToString();
        }
    }
}
