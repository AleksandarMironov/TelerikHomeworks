using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter sw = new StreamWriter("points.txt")) // to do: add option to write in different file
            {

                for (int i = 0; i < path.PointList.Count; i++)
                {
                    sw.WriteLine(path.PointList[i]);
                }

            }
        }
        

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string[] nextPointMass = sr.ReadLine().Split(' ');   //to do: add cheker if there is less than 3 points
                    Point3D nextPoint = new Point3D(double.Parse(nextPointMass[0]), double.Parse(nextPointMass[1]), double.Parse(nextPointMass[2]));
                    path.AddPoint(nextPoint);
                }
            }
            return path;
        }
    }
}
