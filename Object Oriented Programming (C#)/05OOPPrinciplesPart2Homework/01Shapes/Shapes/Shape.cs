using System;


namespace _01Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                NegativeVerification.Width(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                NegativeVerification.Height(value);
                this.height = value;
            }
        }

        public abstract void CalculateSurface();

    }
}
