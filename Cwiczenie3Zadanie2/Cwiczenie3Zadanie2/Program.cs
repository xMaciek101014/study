using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Cwiczenie3Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a = 0;
            uint result = 1;
            Console.WriteLine(a);
            while (true) 
            {
                if (result >= a)
                {
                    result += a;
                    a = result - a;
                    Console.WriteLine(a);
                }
                else
                {
                    break;
                }             
            }
            Console.ReadLine();
          
        }
    }
}
