using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Monster> CreateRandomMonsters(int monsternumb)
        {
            Random random = new Random();
            Monster generatemonster = new Monster();
            for (int i = 0; i < monsternumb; i++) {
                int value = random.Next(1, 4);
                if(value == 1) {
                    Type = MonsterType.Troll;
                }
                if (value == 2) {
                    Type = MonsterType.Ogre;
                }
                if (value == 3) {
                    Type = MonsterType.Elf;
                }
                if (value == 4) {
                    Type = MonsterType.Demon;
                }
                Health = random.NextDouble() * (MaxHealth - 1) + 1;
                Strength = random.Next(1, 200);
                yield return generatemonster;
            }
        }
    }
}
