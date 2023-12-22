using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сначала желаемый размер массива, а затем задайте каждый его элемент\n");
            int[] num = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Square");
            Console.WriteLine(string.Join(", ", num.Square()));
            Console.WriteLine("Cube");
            Console.WriteLine(string.Join(", ", num.Cube()));
            Console.WriteLine("Average");
            Console.WriteLine(num.Average());
            Console.WriteLine("Sum");
            Console.WriteLine(num.Sum());
            Console.WriteLine("Even");
            Console.WriteLine(string.Join(", ", num.Even()));
            Console.WriteLine("Odd");
            Console.WriteLine(string.Join(", ", num.Odd()));

            Console.ReadKey();
        }
    }
}
