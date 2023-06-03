using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            double areaCircle = 0;
            Console.Write("Podaj pole koła: ");
            areaCircle = Double.Parse(Console.ReadLine());
            radius = Math.Sqrt(areaCircle/Math.PI);
            Console.Write("Obwód koła wynosi: " + 2*radius*Math.PI);
            Console.ReadLine();
        }
    }
}
