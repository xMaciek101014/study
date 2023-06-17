using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4Zadanie1
{
    internal class Program
    {
        static int[] myArray = new int[15];
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++) 
            {
                myArray[i] = random.Next(0, 200);
            }
            Console.Write("Tablica od początku do końca: ");
            WriteArray();
            Console.Write("Tablica od końca do początku: ");
            WriteArrayReverse();
            Console.ReadLine();
        }
        static void WriteArray()
        {
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine();
        }
        static void WriteArrayReverse()
        {
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
