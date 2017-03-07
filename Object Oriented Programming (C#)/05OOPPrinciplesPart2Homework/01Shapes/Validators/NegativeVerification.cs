using System;


namespace _01Shapes
{
    public class NegativeVerification
    {
        public static void Width(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Width cannot be a negative number!");
            }
        }

        public static void Height(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Height cannot be a negative number!");
            }
        }
    }
}
