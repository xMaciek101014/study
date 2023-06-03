using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1;
            double value2;
            Console.Write("Podaj pierwszą liczbę: ");
            value1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            value2 = double.Parse(Console.ReadLine());
            if (value1 > value2)
            {
                Console.Write("Większa jest pierwsza liczba: " + value1);
            }
            if (value1 < value2)
            {
                Console.Write("Większa jest druga liczba: " + value2);
            }
            if (value1 == value2)
            {
                Console.Write("Obydwie liczby są równe");
            }
            Console.ReadLine();
        }
    }
}
