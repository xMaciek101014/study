using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie3Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = 0;
            double sum = 0;
            Console.Write("Podaj x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj ilość wyrazów n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(x, i) / GetFactorialValue(i);
            }
            Console.WriteLine("Wartość funkcji e do potęgi x wynosi: " + sum);
            Console.ReadLine();
        }
        public static int GetFactorialValue(int factorialBase)
        {
            int factorialValue = 1;
            for (int i = 1;i <= factorialBase; i++)
            {
                factorialValue *= i;
            }
            return factorialValue;
        }
    }
}
