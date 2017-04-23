using System;

namespace Task_2.Method_PrintStatistics_in_CSharp
{
    public class PrintStatisticsInCsharp
    {
        public void PrintStatistics(double[] array, int count)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty collection.", nameof(array));
            }

            double min = array[0];
            double max = array[0];
            double sum = array[0];

            for (int i = 1; i < count; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }

                sum += array[i];
            }

            double average = sum / count;

            this.PrintValue(min);
            this.PrintValue(max);
            this.PrintValue(average);
        }

        private void PrintValue(double value)
        {
            Console.WriteLine(value);
        }
    }
}
