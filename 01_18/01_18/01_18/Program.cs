using System;
using System.Collections.Generic;

namespace _01_18
{
    class Program
    {
        static void Main(string[] args) {
            // Aceder à classe CompareWeapon.
            CompareWeapon _compareWeapon = new CompareWeapon();

            // Lista de Weapons.
            List<Weapon> weaponList = new List<Weapon>();

            // O construtor constrói objetos que são colocados na lista.
            weaponList.Add(new Weapon(1, 2f));
            weaponList.Add(new Weapon(2, 3f));
            weaponList.Add(new Weapon(3, 4f));
            weaponList.Add(null);

            // Mostrar as Weapons por ordem decrescente pelo Attack Power.
            Console.WriteLine("Weapons por ordem decrescente pelo" +
                " Attack Power:");
            // Ordenar (ordem decrescente pelo AttackPower)
            weaponList.Sort();

            foreach (Weapon item in weaponList) {
                if (item != null) {
                    Console.WriteLine($"Attack power: {item.AttackPower}");
                    Console.WriteLine($"Durability: {item.Durability}");
                }
            }

            // Mostrar as Weapons por ordem crescente pela Durability.
            Console.WriteLine("Weapons por ordem crescente pela Durability");

            // Ordenar (ordem crescente pela Durability)
            weaponList.Sort(_compareWeapon);

            foreach (Weapon item in weaponList) {
                if (item != null) {
                    Console.WriteLine($"Attack power: {item.AttackPower}");
                    Console.WriteLine($"Durability: {item.Durability}");
                }
            }
        }
    }
}
