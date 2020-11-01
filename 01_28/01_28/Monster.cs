using System;
using System.Collections.Generic;
using System.Text;

namespace _01_28
{
    class Monster
    {
        public const double MaxHealth = 100;
        public const int MaxStrength = 200;
        public MonsterType Type { get; set; }
        public double Health { get; set; }
        public int Strength { get; set; }
    }
}
