using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4Zadanie5
{
    internal class Program
    {
        static int[] myArray = new int[] { 10, 25, -17, 48, 0, 3, 72, -4 };
        static void Main(string[] args)
        {
            Console.Write("Tablica przed sortowaniem: ");
            WriteArray();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Swap(i, minIndex);
                }
            }
            Console.Write("Tablica po sortowaniu: ");
            WriteArray();
            Console.ReadLine();
        }
        public static void Swap(int i, int j)
        {
            int temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;
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
