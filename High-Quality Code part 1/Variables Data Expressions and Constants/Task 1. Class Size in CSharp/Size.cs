using System;

namespace Task_1.Class_Size_in_CSharp
{
    public class Size
    {
        private readonly double width;
        private readonly double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedFigureSize(Size size, double rotationAngle)
        {
            if (size == null)
            {
                throw new ArgumentNullException(nameof(size));
            }

            var rotatedFigureWidth =
                (Math.Abs(Math.Cos(rotationAngle)) * size.width) +
                (Math.Abs(Math.Sin(rotationAngle)) * size.height);

            var rotatedFigureHeight =
                (Math.Abs(Math.Sin(rotationAngle)) * size.width) +
                (Math.Abs(Math.Cos(rotationAngle)) * size.height);

            return new Size(rotatedFigureWidth, rotatedFigureHeight);
        }
    }
}