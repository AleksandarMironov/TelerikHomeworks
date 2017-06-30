using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SortAlgorithms.Util
{
    public class TimeTracker
    {
        private const long ExecutionTimes = 100000;

        public static void MeasureTime(string sortingType, Action sortingMethod)
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < ExecutionTimes; i++)
            {
                sortingMethod();
            }

            Logger.Log($"{sortingType} execution time -> {sw.Elapsed.ToString()}");
        }
    }
}
