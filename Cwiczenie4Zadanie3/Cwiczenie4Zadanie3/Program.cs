using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4Zadanie3
{
    internal class Program
    {
        static int[] myArray = new int[] { 10, 25, -17, 48, 0, 3, 72, -4 };
        static void Main(string[] args)
        {
            Console.Write("Tablica przed sortowaniem: ");
            WriteArray();
            bool swapped;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < myArray.Length - i - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped == true)
                    break;
            }
            Console.Write("Tablica po sortowaniu: ");
            WriteArray();
            Console.ReadLine();
        }
        static void WriteArray()
        {
            foreach (int value in myArray)
            {
                Console.Write(value + ", ");
            }
            Console.WriteLine();
        }
    }
}
