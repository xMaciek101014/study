using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie3Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint monthQuantity;
            double startAmount;
            double annualInterestRate;
            double interestRatePerMonth;
            double sum;
            double profit;
            double tax = 0.19;

            Console.Write("Podaj kwotę początkową: ");
            startAmount = double.Parse(Console.ReadLine());
            Console.Write("Podaj oprocentowanie w skali roku: ");
            annualInterestRate = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę miesięcy: ");
            monthQuantity = uint.Parse(Console.ReadLine());

            interestRatePerMonth = annualInterestRate / 12;
            sum = startAmount * (1 + interestRatePerMonth / 100) * monthQuantity;
            profit = sum - (startAmount * monthQuantity);

            Console.WriteLine($"Po {monthQuantity} miesiącach zysk wyniesie: {profit}zł.");
            Console.WriteLine($"Po odjęciu podatku Belki (19%) zysk wynosi: " + (profit - (profit * tax)));
            Console.ReadLine();
        }
    }
}
