using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2Zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int a = 0;
            int b = 0;
            int r;
            Console.Write("Podaj współrzędną X punktu P: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj współrzędną Y punktu P: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Podaj promień koła: ");
            r = int.Parse(Console.ReadLine());
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                Console.Write("Punkt leży w obrębie koła.");
            }
            else
            {
                Console.Write("Punkt leży poza obrębem koła.");
            }
            Console.ReadLine();

        }
    }
}
