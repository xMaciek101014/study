using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie8Zadanie3
{
    enum Rarity
    {
        Powszechny,
        Rzadki,
        Unikalny,
        Epicki
    }
    enum ItemType
    {
        Bron,
        Zbroja,
        Amulet,
        Pierscien,
        Helm,
        Tarcza,
        Buty
    }
    struct Item
    {
        public double Weight;
        public int Value;
        public Rarity Rarity;
        public ItemType Type;
        public string Name;
        public void FillItem(double weight, int value, Rarity rarity, ItemType type, string name)
        {
            Weight = weight;
            Value = value;
            Rarity = rarity;
            Type = type;
            Name = name;
        }
        public void DisplayInformation()
        {
            Console.WriteLine("Przedmiot: " + Name);
            Console.WriteLine("Typ: " + Type);
            Console.WriteLine("Rzadkość: " + Rarity);
            Console.WriteLine("Waga: " + Weight);
            Console.WriteLine("Wartość: " + Value + " sztuk złota");
        }
    }
    class Program
    {
        static Item RandomItem(Item[] items)
        {
            Random random = new Random();
            Rarity[] rarities = { Rarity.Powszechny, Rarity.Rzadki, Rarity.Unikalny, Rarity.Epicki };
            double[] chances = { 0.6, 0.3, 0.08, 0.02 };
            double randomValue = random.NextDouble();
            double sumChances = 0.0;
            for (int i = 0; i < chances.Length; i++)
            {
                sumChances += chances[i];
                if (randomValue < sumChances)
                {
                    Rarity selectedRarity = rarities[i];
                    Item[] availableItems = Array.FindAll(items, item => item.Rarity == selectedRarity);
                    int index = random.Next(availableItems.Length);
                    return availableItems[index];
                }
            }
            return items[random.Next(items.Length)];
        }

        static void Main(string[] args)
        {
            Item[] items = new Item[8];
            items[0].FillItem(2.5, 10, Rarity.Powszechny, ItemType.Bron, "Miecz");
            items[1].FillItem(1.0, 20, Rarity.Rzadki, ItemType.Zbroja, "Pancerz");
            items[2].FillItem(0.5, 50, Rarity.Unikalny, ItemType.Amulet, "Amulet Mocy");
            items[3].FillItem(0.2, 100, Rarity.Epicki, ItemType.Pierscien, "Pierścien Nieskończonosci");
            items[4].FillItem(1.5, 15, Rarity.Powszechny, ItemType.Helm, "Hełm Rycerza");
            items[5].FillItem(0.8, 25, Rarity.Rzadki, ItemType.Tarcza, "Tarcza Odporności");
            items[6].FillItem(1.2, 35, Rarity.Unikalny, ItemType.Buty, "Buty Zwinności");
            items[7].FillItem(0.3, 80, Rarity.Epicki, ItemType.Amulet, "Amulet Życia");
            Item randomItem = RandomItem(items);
            Console.WriteLine("Wylosowany przedmiot: ");
            randomItem.DisplayInformation();
            Console.ReadLine();
        }
    }
}
