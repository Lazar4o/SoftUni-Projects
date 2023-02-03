using System;
using System.Linq;
using System.Collections.Generic;

namespace DungeonQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();
            //!keyMaterials.ContainsKey(material)
            bool isObtained = false;
            string obtainedItem = string.Empty;

            while (!isObtained)
            {
                string[] givenMaterials = Console.ReadLine().Split();

                for (int i = 0; i < givenMaterials.Length; i += 2)
                {
                    int numOfMaterials = int.Parse(givenMaterials[i]);
                    string material = givenMaterials[i + 1].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!keyMaterials.ContainsKey(material))
                        {
                            keyMaterials.Add(material, numOfMaterials);

                        }
                        else
                        {
                            keyMaterials[material] += numOfMaterials;
                        }
                        foreach (var item in keyMaterials)
                        {
                            if (item.Value >= 250)
                            {
                                isObtained = true;
                                obtainedItem = item.Key;
                            }
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(material))
                        {
                            junks.Add(material, numOfMaterials);

                        }
                        else
                        {
                            junks[material] += numOfMaterials;
                        }
                    }
                    if (isObtained)
                    {
                        break;
                    }
                }
            }
            keyMaterials[obtainedItem] -= 250;
            switch (obtainedItem)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }
            bool isMotes = false;
            bool isShards = false;
            bool isFragments = false;
            foreach (var (key, value) in keyMaterials)
            {
                if (key == "motes")
                {
                    isMotes = true;
                }
                else if (key == "shards")
                {
                    isShards = true;
                }
                else if (key == "fragments")
                {
                    isFragments = true;
                }
            }
            foreach (var importantItems in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{importantItems.Key}: {importantItems.Value}");
            }
            if (!isFragments)
            {
                Console.WriteLine($"fragments: 0");
            }
            if (!isMotes)
            {
                Console.WriteLine($"motes: 0");
            }
            if (!isShards)
            {
                Console.WriteLine($"shards: 0");
            }
            foreach (var junk in junks.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }

        }
    }
}
