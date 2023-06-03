using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1;
            double value2;
            double value3;
            Console.Write("Podaj pierwszy bok: ");
            value1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugi bok: ");
            value2 = double.Parse(Console.ReadLine());
            Console.Write("Podaj trzeci bok: ");
            value3 = double.Parse(Console.ReadLine());
            if (value1 == value2 && value1 == value3)
            {
                Console.Write("Boki mogą utworzyć trójkąt równoboczny");
            }
            else
            {
                Console.Write("Boki nie mogą utworzyć trójkąta równobocznego");
            }
            Console.ReadLine();
        }
    }
}
