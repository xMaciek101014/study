using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie3Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint x = 0;
            Console.Write("Podaj liczbę x: ");
            x = uint.Parse(Console.ReadLine());
            uint n = FindFactorialNumber(x);
            if (n != 0)
            {
                Console.WriteLine($"{x} jest silnią liczby {n}.");
            }
            else
            {
                Console.WriteLine($"{x} nie jest silnią żadnej liczby.");
            }
            Console.ReadLine();
        }

        public static uint FindFactorialNumber(uint x)
        {
            uint factorial = 1;
            for (uint i = 1; i <= x; i++)
            {
                factorial *= i;
                if (factorial == x)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
