using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static int CountSmileys(string[] arr)
        {
            return arr.Count(s => IsSmiley(s));
        }
        static bool IsSmiley(string smile)
        {
            return (smile.Length == 2 || smile.Length == 3 && (smile[1] == '-' || smile[1] == '~')) &&
                   (smile[0] == ':' || smile[0] == ';') &&
                   (smile[smile.Length - 1] == ')' || smile[smile.Length - 1] == 'D');
        }
        static void Main(string[] args)
        {
            string[] clowns = { ":(", ";D", ":~)", ";~D", ";)", ":D", ":-)", ";-D", ":~(", ";(" };
            uint smiles = (uint)CountSmileys(clowns);
            Console.WriteLine($"Число улыбок: {smiles}");
            Console.ReadKey();
        }
    }
}
