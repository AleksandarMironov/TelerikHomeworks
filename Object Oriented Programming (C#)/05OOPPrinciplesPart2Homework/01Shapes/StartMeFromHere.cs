using System;
using System.Collections.Generic;

namespace _01Shapes
{
    class StartMeFromHere
    {
        static void Main()
        {
            var shapes = new List<Shape>
            {
                new Rectangle(3.5, 6.3),
                new Square(2.2),
                new Triangle(8, 5.9)
            };

            foreach (var shape in shapes)
            {
                shape.CalculateSurface();
            }
        }
    }
}
