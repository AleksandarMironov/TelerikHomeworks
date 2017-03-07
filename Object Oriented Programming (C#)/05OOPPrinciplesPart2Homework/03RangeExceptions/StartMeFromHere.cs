using System;

namespace _03RangeExceptions
{
    class StartMeFromHere
    {
        static void Main()
        {
            try
            {
                string[] names = new string[101];
                if (names.Length < 1 || names.Length > 100)
                {
                    throw new InvalidRangeException<int>("Length is out of range!", 1, 100);
                }

            }
            catch (InvalidRangeException<int> exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                DateTime dateAndTime = new DateTime(1597, 3, 23);
                if (dateAndTime < new DateTime(1980, 1, 1) || dateAndTime > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Year is out of range!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (InvalidRangeException<DateTime> exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
