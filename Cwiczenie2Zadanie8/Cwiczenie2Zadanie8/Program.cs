using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2Zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1;
            double value2;
            byte mathType;
            Console.Write("Podaj pierwszą liczbę: ");
            value1 = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            value2 = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę odpowiadającą działaniu: ");
            mathType = byte.Parse(Console.ReadLine());
            switch(mathType) 
            {
                case 1:
                    Console.Write($"Suma liczb wynosi: {value1 + value2}");
                    break;
                case 2:
                    Console.Write($"Różnica liczb wynosi: {value1 - value2}");
                    break;
                case 3:
                    Console.Write($"Iloczyn liczb wynosi: {value1 * value2}");
                    break;
                case 4:
                    if (value2 != 0)
                    {
                        Console.Write($"Iloraz liczb wynosi: {value1 / value2}");
                    }
                    else
                    {
                        Console.Write($"Dla liczb {value1} i {value2} wynikiem jest {value1}/{value2}");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
