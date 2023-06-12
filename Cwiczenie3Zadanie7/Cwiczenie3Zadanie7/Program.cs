using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie3Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = 0;
            Console.Write("Podaj liczbę naturalną n: ");
            n = uint.Parse(Console.ReadLine());
            //Zero nie jest brane pod uwagę!
            Console.WriteLine($"Pary liczb, których suma jest równa {n}:");
            for (uint firstValue = 1; firstValue <= n / 2; firstValue++)
            {
                uint secondValue = n - firstValue;

                Console.WriteLine($"{firstValue} oraz {secondValue}");
            }
            Console.ReadLine();
        }
    }
}
