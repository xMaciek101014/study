using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double personHeight = 0;
            double personWeight = 0;
            Console.Write("Podaj wzrost (m): ");
            personHeight = Double.Parse(Console.ReadLine());
            Console.Write("Podaj wagę (kg): ");
            personWeight = Double.Parse(Console.ReadLine());
            Console.WriteLine($"BMI wynosi: {personWeight / (personHeight * personHeight)}");
            Console.ReadLine();
        }
    }
}
