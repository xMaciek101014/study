using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie4Zadanie2
{
    internal class Program
    {
        static int[] myArray = new int[] { 10, 25, -17, 48, 0, 3, 72, -4};
        static void Main(string[] args)
        {
            Console.Write("Moja tablica to: ");
            WriteArray();
            GetMinValue();
            GetMaxValue();
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
        static void GetMinValue()
        {
            int index = -1;
            for (int i = 0; i < myArray.Length; i++) 
            {
                if (index > -1)
                {
                    if (myArray[i] < myArray[index])
                    {
                        index = i;
                    }
                }
                else
                {
                    index = i;
                }
            }
            Console.WriteLine("Najmniejsza wartość tablicy to: " + myArray[index]);
        }
        static void GetMaxValue() 
        {
            int index = -1;
            for (int i = 0; i < myArray.Length; i++) 
            {
                if (index > -1)
                {
                    if (myArray[i] > myArray[index])
                    {
                        index = i;
                    }
                }
                else
                {
                    index = i;
                }
            }
            Console.WriteLine("Największa wartość tablicy to: " + myArray[index]);
        }
    }
}
