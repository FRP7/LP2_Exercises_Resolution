using System;
using System.Collections.Generic;
using System.Text;

namespace _01_31
{
    public class Loot
    {
        public LootType WhatKindOfLootAmI { get; set; }
        public string Description { get; set; }
        public ulong Value { get; set; }

        public Loot(LootType whatkindoflootami, string description, ulong value) {
            WhatKindOfLootAmI = whatkindoflootami;
            Description = description;
            Value = value;
            Console.WriteLine($"Type: {whatkindoflootami}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Value: {value}");
        }
    }
}
