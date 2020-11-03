using System;
using System.Collections.Generic;

namespace _01_18
{
    class Program
    {
        // Aceder à classe Sort.
        private static Sort _sort = new Sort();
        //

        static void Main(string[] args)
        { 
             // Lista de Weapons.
            List<Weapon> weaponlist = new List<Weapon>();
            // 

            // O construtor constrói objetos que são colocados na lista.
            weaponlist.Add(new Weapon
                (1, 2f));
            weaponlist.Add(new Weapon
                (2, 3f));
            weaponlist.Add(new Weapon
                (3, 4f));
            //

            // Mostrar as Weapons por ordem decrescente pelo Attack Power.
            Console.WriteLine("Weapons por ordem decrescente pelo Attack Power");
            // Ordenar (ordem decrescente pelo AttackPower)
            weaponlist.Sort();
            //
            foreach (Weapon item in weaponlist)
            {
                Console.WriteLine($"Attack power: {item.AttackPower}");
                Console.WriteLine($"Durability: {item.Durability}");
            }
            //
            // Mostrar as Weapons por ordem crescente pela Durability.
            Console.WriteLine("Weapons por ordem crescente pela Durability");

            // Ordenar (ordem crescente pela Durability)
            weaponlist.Sort(_sort);
            //
            foreach (Weapon item in weaponlist)
            {
                Console.WriteLine($"Attack power: {item.AttackPower}");
                Console.WriteLine($"Durability: {item.Durability}");
            }
            //
        }
    }
}
