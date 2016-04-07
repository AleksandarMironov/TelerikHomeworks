using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());  //2.5    ///inside
            double y = double.Parse(Console.ReadLine());    //1
            double xCircle = 1;
            double yCircle = 1;
            double radiusCircle = 1.5;
            bool insideCircle = (x - xCircle) * (x - xCircle) + (y - yCircle) * (y - yCircle) <= radiusCircle * radiusCircle;
            bool insideRec = y >= -1 && y <= 1; //x <= 1 && x >= -5; && 
            string inCircle = insideCircle ? "inside circle" : "outside circle";
            string inRec = insideRec ? "inside rectangle" : "outside rectangle";
            Console.WriteLine(inCircle + " " + inRec);
            //(top=1, left=-1, width=6, height=2).
        }
    }
}
