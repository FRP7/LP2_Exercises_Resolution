﻿using System;
using System.Collections.Generic;

namespace Weapon
{
    class Program
    {
        // Aceder à classe Sort.
        private static Sort _sort = new Sort();
        //
        // Lista de Weapons.
        private static List<Weapon> weaponlist = new List<Weapon>();
        // 

        static void Main(string[] args) {
            // O construtor constrói objetos que são colocados na lista.
            weaponlist.Add(new Weapon
                (name: "Sword", attackPower: 1, durability: 2f));
            weaponlist.Add(new Weapon
                (name: "Axe", attackPower: 2, durability: 3f));
            weaponlist.Add(new Weapon
                (name: "Mace", attackPower: 3, durability: 4f));
            //

            // Mostrar as Weapons por ordem decrescente pelo Attack Power.
            Console.WriteLine(Environment.NewLine);
         Console.WriteLine("Weapons por ordem decrescente pelo Attack Power");
            // Ordenar (ordem decrescente pelo AttackPower)
            weaponlist.Sort();
            //
            foreach (Weapon item in weaponlist) {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(item.Name);
                Console.WriteLine($"Attack power: {item.AttackPower}");
                Console.WriteLine($"Durability: {item.Durability}");
            }
            //
            // Mostrar as Weapons por ordem crescente pela Durability.
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Weapons por ordem crescente pela Durability");

            // Ordenar (ordem crescente pela Durability)
            weaponlist.Sort(_sort);
            //
            foreach (Weapon item in weaponlist) {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(item.Name);
                Console.WriteLine($"Attack power: {item.AttackPower}");
                Console.WriteLine($"Durability: {item.Durability}");
            }
            //
        }
    }
}
