using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class ExtendedClassArray
    {
        public static int[] Square(this int[] arr)
        {
            return arr.Select(x => x * x).ToArray();
        }

        public static int[] Cube(this int[] arr)
        {
            return arr.Select(x => x * x * x).ToArray();
        }

        public static double Average(this int[] arr)
        {
            if (arr.Length == 0)
                return double.NaN;

            double sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }

        public static int Sum(this int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        public static int[] Even(this int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }

        public static int[] Odd(this int[] arr)
        {
            return arr.Where(x => x % 2 != 0).ToArray();
        }
    }
}
