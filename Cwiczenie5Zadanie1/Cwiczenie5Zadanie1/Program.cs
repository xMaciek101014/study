using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie5Zadanie1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Podaj liczbę liczb pierwszych: ");
            int quantityNumbers = int.Parse(Console.ReadLine());
            int countFoundedNumbers = 0;
            int number = 2;
            while (countFoundedNumbers < quantityNumbers)
            {
                if (CheckIfNumberIsPrime(number))
                {
                    Console.WriteLine(number);
                    countFoundedNumbers++;
                }
                number++;
            }
            Console.ReadLine();
        }
        static bool CheckIfNumberIsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }                    
            }
            return true;
        }
    }
}
