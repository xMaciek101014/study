using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie6Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1:");
            Exercise1();
            Console.WriteLine("Zadanie 2:");
            Exercise2();
        }
        static void Exercise1()
        {
            Console.Write("Podaj rozmiar tablicy (liczba wierszy i kolumn): ");
            uint rowsAndColumnsQuantity;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out rowsAndColumnsQuantity) && rowsAndColumnsQuantity >= 1)
                    break;

                Console.Write("Niepoprawny rozmiar tablicy. Podaj liczbę naturalną większą od 0: ");
            }
            int[,] array = new int[rowsAndColumnsQuantity, rowsAndColumnsQuantity];
            for (int row = 0; row < rowsAndColumnsQuantity; row++)
            {
                if (row % 2 == 0)
                {
                    for (int column = 0; column < rowsAndColumnsQuantity; column++)
                    {
                        array[row, column] = row * (int)rowsAndColumnsQuantity + column + 1;
                    }
                }
                else
                {
                    for (int column = 0; column < rowsAndColumnsQuantity; column++)
                    {
                        array[row, column] = (row + 1) * (int)rowsAndColumnsQuantity - column;
                    }
                }
            }
            for (int row = 0; row < rowsAndColumnsQuantity; row++)
            {
                for (int column = 0; column < rowsAndColumnsQuantity; column++)
                {
                    Console.Write(array[row, column] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Exercise2()
        {
            Console.Write("Podaj rozmiar tablicy (liczba wierszy i kolumn): ");
            uint rowsAndColumnsQuantity;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out rowsAndColumnsQuantity) && rowsAndColumnsQuantity >= 1)
                    break;

                Console.Write("Niepoprawny rozmiar tablicy. Podaj liczbę naturalną większą od 0: ");
            }
            int[,] array = new int[rowsAndColumnsQuantity, rowsAndColumnsQuantity];
            int number = 1;
            int row = 0;
            int column = 0;
            string direction = "right";
            while (number <= rowsAndColumnsQuantity * rowsAndColumnsQuantity)
            {
                array[row, column] = number;
                switch (direction)
                {
                    case "right":
                        column++;
                        if (column == rowsAndColumnsQuantity || array[row, column] != 0)
                        {
                            column--;
                            row++;
                            direction = "down";
                        }
                        break;
                    case "down":
                        row++;
                        if (row == rowsAndColumnsQuantity || array[row, column] != 0)
                        {
                            row--;
                            column--;
                            direction = "left";
                        }
                        break;
                    case "left":
                        column--;
                        if (column == -1 || array[row, column] != 0)
                        {
                            column++;
                            row--;
                            direction = "up";
                        }
                        break;
                    case "up":
                        row--;
                        if (row == -1 || array[row, column] != 0)
                        {
                            row++;
                            column++;
                            direction = "right";
                        }
                        break;
                }
                number++;
            }
            for (row = 0; row < array.GetLength(0); row++)
            {
                for (column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
