using System;


namespace _01Shapes
{
    public class Square : Shape
    {
        public Square(double width) : base(width, width)
        {

        }

        public override void CalculateSurface()
        {
            var result = Width * Width;
            Console.WriteLine("Area of {0} -> {1}", this.GetType().Name, result);
        }
    }
}
