using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Distance
    {
        public static double CalculateDistance(Point3D pointOne, Point3D pointTwo)
        {
            double distance = 0;
            distance = Math.Sqrt((pointOne.X - pointTwo.X) * (pointOne.X - pointTwo.X) +
                                (pointOne.Y - pointTwo.Y) * (pointOne.Y - pointTwo.Y) +
                                (pointOne.Z - pointTwo.Z) * (pointOne.Z - pointTwo.Z));
            return distance;
        }
    }
}
