using System;


namespace _01Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }

        public override void CalculateSurface()
        {
            var result = Height * Width;
            Console.WriteLine("Area of {0} -> {1}", this.GetType().Name, result);
        }
    }
}
