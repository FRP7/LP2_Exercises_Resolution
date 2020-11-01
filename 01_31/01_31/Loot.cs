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
    }
}
