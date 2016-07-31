using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static readonly Point3D O = new Point3D(0, 0, 0);


        public Point3D(double x = 0, double y = 0, double z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string outputToString = $"[ {this.X} {this.Y} {this.Z} ]";
            return outputToString;
        }
    }


}

