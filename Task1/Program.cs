using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static string PrintRomb(int n)
        {

            if (n % 2 == 0 || n < 0)
            {
                Console.WriteLine("невозможно напечатать ромб четного или отрицательного размера.");
                return null;
            }

            string romb = "";


            for (int i = 0; i < n; i++)
            {
                int spaces = Math.Abs((n - 1) / 2 - i);

                int stars = n - spaces * 2;

                romb += new string(' ', spaces) + new string('*', stars) + "\n";
            }



            return romb;
        }

        public static void Main(string[] args)
        {
            int n = 29;
            string romb = PrintRomb(n);
            Console.WriteLine(romb);
            Console.ReadKey();
        }
    }
}
