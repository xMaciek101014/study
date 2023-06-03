using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie1Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1 = 0;
            double value2 = 0;
            double value3 = 0;
            Console.Write("Podaj pierwszą liczbę: ");
            value1 = Double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            value2 = Double.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            value3 = Double.Parse(Console.ReadLine());
            Console.Write("Średnia arytmetyczna trzech liczb wynosi: " + (value1+value2+value3)/3);
            Console.ReadLine();
        }
    }
}
