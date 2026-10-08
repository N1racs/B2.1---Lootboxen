using System;
using System.Collections.Generic;

namespace B2._1___Lootboxen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            Random random = new Random();
            string howManyLootboxes = "Wie viele Lootboxen möchtest du öffnen?";
            string toManyLootboxes = "Ungültige Eingabe! Bitte gib eine Zahl zwischen 1 und 5 ein.";
            string droppedItems = "Deinem Inventar wurden folgende Items hinzugefügt: ";
            bool output = false;
            int lootboxCount;
            #endregion

            List<string> itemList = CreateItems();

            Console.WriteLine(howManyLootboxes);
            Console.Write("> ");
            string input = Console.ReadLine();
            output = int.TryParse(input, out lootboxCount);

            while (!output || lootboxCount > 5 || lootboxCount < 1)
            {
                Console.WriteLine(toManyLootboxes);
                Console.Write("> ");
                input = Console.ReadLine();
                output = int.TryParse(input, out lootboxCount);

            }

            List<string> itemRewards = LootboxOutput(random, lootboxCount, itemList);

            Console.WriteLine(droppedItems);

            foreach (string currentItem in itemRewards)
            {
                Console.WriteLine("> " + currentItem);
            }

        }
        /// <summary>
        /// Creates a list and adds all available items to it.
        /// </summary>
        /// <returns></returns>
        static List<string> CreateItems()
        {
            List<string> itemList = new List<string>();
            itemList.Add("Moonstone");
            itemList.Add("Dragon Scale");
            itemList.Add("Phoenix Feather");
            itemList.Add("Shadow Dagger");
            itemList.Add("Mana Crystal");
            itemList.Add("Ancient Rune");
            itemList.Add("Frost Core");
            itemList.Add("Storm Relic");
            itemList.Add("Soul Gem");
            itemList.Add("Dragon Egg");

            return itemList;

        }
        /// <summary>
        /// Randomly selects items and adds them to a reward list.
        /// </summary>
        /// <param name="random">Generates random item selections.</param>
        /// <param name="lootboxCount">Specifies how many lootboxes to open.</param>
        /// <param name="itemList">Contains all available items to choose from.</param>
        /// <returns></returns>
        static List<string> LootboxOutput(Random random, int lootboxCount, List<string> itemList)
        {
            List<string> itemRewards = new List<string>();

            for (int i = 0; i < lootboxCount; i++)
            {

                int randomIndex = random.Next(0, itemList.Count);
                string randomItem = itemList[randomIndex];
                itemRewards.Add(randomItem);
                Console.WriteLine("Lootbox " + (i + 1) + ": " + randomItem);
            }
            return itemRewards;

        }
    }
}
