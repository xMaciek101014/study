using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie5Zadanie3
{
    internal class Program
    {
        static uint minColumnIndexToWritePlus;
        static uint maxColumnIndexToWritePlus;
        static void Main(string[] args)
        {
            uint quantityRows;
            uint quantityColumns = 1;
            Console.Write("Podaj liczbę wierszy: ");
            quantityRows = uint.Parse(Console.ReadLine());
            for (int i = 2; i <= quantityRows; i++)
            {
                quantityColumns += 2;
            }
            minColumnIndexToWritePlus = quantityColumns / 2;
            maxColumnIndexToWritePlus = quantityColumns / 2;
            for (int i = 0; i < quantityRows; i++) 
            {
                for (int j = 0; j < quantityColumns; j++) 
                {
                    WriteRowColumn(j);
                }
                minColumnIndexToWritePlus--;
                maxColumnIndexToWritePlus++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void WriteRowColumn(int currentColumnIndex)
        {
            if (currentColumnIndex >= minColumnIndexToWritePlus && currentColumnIndex <= maxColumnIndexToWritePlus)
            {
                Console.Write("+ ");
            }
            else
            {
                Console.Write("  ");
            }
        }
    }
}
