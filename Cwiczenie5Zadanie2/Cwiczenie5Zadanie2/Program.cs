using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie5Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Version1();
            //Version2();
        }
        static void Version1()
        {
            uint quantityNumbers;
            uint quantityDraws = 0;
            Random random = new Random();
            Console.Write("Podaj ilość liczb parzysztych do wylosowania: ");
            quantityNumbers = uint.Parse(Console.ReadLine());
            Console.Write("Wylosowane liczby parzyste: ");
            for (uint i = 0; i < quantityNumbers; i++)
            {
                int drawNumber;
                do
                {
                    drawNumber = random.Next(-8, 9);
                    quantityDraws++;
                } while (drawNumber % 2 != 0);
                Console.Write($"{drawNumber}, ");

            }
            Console.WriteLine();
            Console.WriteLine("Liczba wykonanych losowań: " + quantityDraws);
            Console.ReadLine();
        }
        static void Version2()
        {
            uint quantityNumbers;
            uint quantityDraws = 0;
            Random random = new Random();
            Console.Write("Podaj ilość liczb parzysztych do wylosowania: ");
            quantityNumbers = uint.Parse(Console.ReadLine());
            Console.Write("Wylosowane liczby parzyste: ");
            for (uint i = 0; i < quantityNumbers; i++)
            {
                int drawNumber = random.Next(-4, 5) * 2;
                quantityDraws++;
                Console.Write($"{drawNumber}, ");
            }
            Console.WriteLine();
            Console.WriteLine("Liczba wykonanych losowań: " + quantityDraws);
            Console.ReadLine();
        }
    }
}
