using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie3Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint baseForPowering;
            uint exponentOfPower;
            uint result = 1;
            Console.Write("Podaj podstawę potęgowania: ");
            baseForPowering = uint.Parse(Console.ReadLine());
            Console.Write("Podaj wykładnik potęgowania: ");
            exponentOfPower = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= exponentOfPower; i++) 
            {
                result *= baseForPowering;
            }
            Console.Write("Wynik potęgowania wynosi: " + result);
            Console.ReadLine();
        }
    }
}
