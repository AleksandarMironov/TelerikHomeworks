using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        private double size;
        private long numberOfColors;

        public double Size
        {
            get
            {
                return this.size;
                
            }
            set
            {
                this.size = value;
                
            }
        }

        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
                
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Displays must have atleast 2 colors");
                }
                this.numberOfColors = value;
            } 
        }

        public Display(double size, long numberOfColors)
        {
            this.numberOfColors = numberOfColors;
            this.size = size;
        }

        public override string ToString()
        {
            return $"Display:\n \tColors: {this.numberOfColors} / Size: {this.size}";
        }
    }
}
