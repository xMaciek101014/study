using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie3Zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;
            int searched = 0;
            int answer = -1;
            Console.WriteLine("Pomyśl liczbę z przedziału od 1 do 20.");
            Console.WriteLine("Jeśli liczba jest mniejsza wpisz ujemną liczbe.");
            Console.WriteLine("Jeśli liczba jest większa wpisz dodatnią liczbę.");
            Console.WriteLine("Jeśli liczba jest poprawna wpisz 0.");
            while (answer != 0)
            {
                searched = (min + max) / 2;
                Console.Write($"Czy Twoja liczba to {searched}? Podaj odpowiedź: ");
                answer = int.Parse(Console.ReadLine());
                if (answer < 0)
                {
                    max = searched - 1;
                }
                if (answer > 0)
                {
                    min = searched + 1;
                }
                if (answer == 0)
                {
                    Console.WriteLine($"Twoja liczba to {searched}.");
                }
            }
            Console.ReadLine();
        }
    }
}
