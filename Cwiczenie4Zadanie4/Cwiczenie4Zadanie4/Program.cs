using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4Zadanie4
{
    internal class Program
    {
        static int[] myArray = new int[] { 10, 25, -17, 48, 0, 3, 72, -4 };
        static void Main(string[] args)
        {
            Console.Write("Tablica przed sortowaniem: ");
            WriteArray();
            for (int i = 1; i < myArray.Length; i++)
            {
                int key = myArray[i];
                int j = i - 1;
                while (j >= 0 && myArray[j] > key)
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }
                myArray[j + 1] = key;
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
