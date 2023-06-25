using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie6Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            for (int row = 0; row < 10; row++)
            {
                if (row % 2 == 0)
                {
                    for (int column = 0; column < 10; column++)
                    {
                        array[row, column] = row * 10 + column + 1;
                    }
                }
                else
                {
                    for (int column = 0; column < 10; column++)
                    {
                        array[row, column] = (row + 1) * 10 - column;
                    }
                }
            }
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Console.Write(array[row, column] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
