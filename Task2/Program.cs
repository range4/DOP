using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        public static string[] SortArr(string[] array)
        {
            return array.OrderBy(str => str.Length).ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сначала желаемый размер массива, а затем задайте каждый его элемент\n");

            string[] arr = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            string[] sortedArr = SortArr(arr);
            Console.WriteLine(string.Join(", ", sortedArr));
            Console.ReadKey();


        }
    }
}
