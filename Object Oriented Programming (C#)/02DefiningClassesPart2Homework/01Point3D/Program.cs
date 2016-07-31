using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point3D(1, 2, 3);
            Console.WriteLine(point);

            Console.WriteLine(Point3D.O);

            Console.WriteLine(Distance.CalculateDistance(point, Point3D.O));

            Console.WriteLine(Environment.NewLine + "From file:" + Environment.NewLine);


            var path = new Path();
            path = PathStorage.LoadPath("points.txt");
            for (int i = 0; i < path.PointList.Count; i++)
            {
                Console.WriteLine(path.PointList[i]);
            }
            


        }
    }
}
