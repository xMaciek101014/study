using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie3Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = 0;
            int nFactorialBase = 0;
            int kFactorialBase = 0;
            int nFactorialValue = 1;
            int kFactorialValue = 1;
            while (nFactorialBase < 5)
            {
                Console.Write("Podaj liczbę naturalną n, która nie może być mniejsza od 5: ");
                nFactorialBase = int.Parse(Console.ReadLine());
            }
            while (kFactorialBase < 5)
            {
                Console.Write("Podaj liczbę naturalną k, która nie może być mniejsza od 5: ");
                kFactorialBase = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= nFactorialBase; i++) 
            { 
                nFactorialValue *= i;
            }
            for (int i = 1; i <= kFactorialBase; i++)
            {
                kFactorialValue *= i;
            }
            m = ((double)(nFactorialValue - kFactorialValue) / kFactorialValue);
            Console.WriteLine("Parametr m wynosi: " + m);
            Console.ReadLine();
        }
    }
}
