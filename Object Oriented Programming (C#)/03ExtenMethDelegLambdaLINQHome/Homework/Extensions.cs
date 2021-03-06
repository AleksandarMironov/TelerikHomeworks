﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder builder, int startIndex, int length)
        {
            var result = new StringBuilder();
            int symbCounter = 0;

            for (int i = startIndex; symbCounter < length; i++)
            {
                result.Append(builder[i]);
                symbCounter++;
            }

            return result;
        }

        public static T MySum<T>(this IEnumerable<T> collection)
            where T : struct, IConvertible
        {
            T sum = default(T);

            foreach (var number in collection)
            {
                sum += (dynamic)number;
            }

            return sum;
        }

        public static T MyProduct<T>(this IEnumerable<T> collection)
            where T : struct, IConvertible
        {
            T product = default(T) + (dynamic)1;

            foreach (var number in collection)
            {
                product *= (dynamic)number;
            }

            return product;
        }

        public static T MyAverage<T>(this IEnumerable<T> collection)
            where T : struct, IConvertible
        {
            T average = default(T);
            int length = 0;

            foreach (var number in collection)
            {
                average += (dynamic)number;
                length++;
            }

            return (dynamic)average / length;
        }

        public static T MyMax<T>(this IEnumerable<T> collection)
            where T : struct, IConvertible
        {
            T max = (dynamic)collection.ElementAt(0);

            foreach (var number in collection)
            {
                if ((dynamic)number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        public static T MyMin<T>(this IEnumerable<T> collection)
            where T : struct, IConvertible
        {
            T min = (dynamic)collection.ElementAt(0);

            foreach (var number in collection)
            {
                if ((dynamic)number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        public static List<Student> ExtractAndOrder(this List<Student> stCollection)
        {
            var group =  from student in stCollection
                         where student.GroupNumber == "1"   
                         select student;

            return new List<Student>(group);
        }

        public static bool ContainsAtLeast(this List<byte> collection, int element, int times)
        {
            bool doesContain = false;
            int counter = 0;

            foreach (var item in collection)
            {
                if (item == element)
                {
                    counter++;
                }

                if (counter == times)
                {
                    doesContain = true;
                    break;
                }
            }

            return doesContain;
        }
    }
}
