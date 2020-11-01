using System;

namespace _01_31
{
    class Program
    {
        private static Loot _loot;

        static void Main(string[] args) {
            _loot = new Loot(
                whatkindoflootami: LootType.Health, 
                description: "Powerful health",
                value: 10
                );

            _loot = new Loot(
               whatkindoflootami: LootType.Ammo,
               description: "Powerful Ammo",
               value: 20
               );

            _loot = new Loot(
               whatkindoflootami: LootType.Shield,
               description: "Powerful shield",
               value: 30
               );

            _loot = new Loot(
               whatkindoflootami: LootType.Weapon,
               description: "Powerful weapon",
               value: 40
               );

            _loot = new Loot(
               whatkindoflootami: LootType.Collectible,
               description: "Powerful collectible",
               value: 50
               );
        }
    }
}
