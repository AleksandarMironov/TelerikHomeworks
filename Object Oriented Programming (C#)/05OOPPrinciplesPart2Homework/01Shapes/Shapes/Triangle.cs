using System;


namespace _01Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override void CalculateSurface()
        {
            var result = (Height * Width) / 2;
            Console.WriteLine("Area of {0} -> {1}", this.GetType().Name, result);
        }
    }
}
