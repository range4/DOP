using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        public static bool CalculateMin(int[] array, out int res)
        {
            int min = array[0];
            foreach (var i in array)
            {
                min = Math.Min(Math.Abs(i), min);
            }

            foreach (var i in array)
            {
                if (i == -min)
                {
                    res = 0;
                    return false;
                }
            }

            res = min;
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сначала желаемый размер массива, а затем задайте каждый его элемент\n");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int nearzero = 0;
            CalculateMin(arr,out nearzero);
            Console.WriteLine(string.Join(", ", nearzero));
            Console.ReadKey();
        }
    }
}
