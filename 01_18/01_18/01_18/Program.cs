using System;
using System.Collections.Generic;

namespace _01_18
{
    class Program
    {
        static void Main(string[] args)
        {
        // Aceder à classe CompareWeapon.
        CompareWeapon _compareweapon = new CompareWeapon();
        //
        // Lista de Weapons.
        List<Weapon> weaponlist = new List<Weapon>();
            // 

            // O construtor constrói objetos que são colocados na lista.
            weaponlist.Add(new Weapon(1, 2f));
            weaponlist.Add(new Weapon(2, 3f));
            weaponlist.Add(new Weapon(3, 4f));
            weaponlist.Add(null);
            //

            // Mostrar as Weapons por ordem decrescente pelo Attack Power.
            Console.WriteLine("Weapons por ordem decrescente pelo Attack Power: ");
            // Ordenar (ordem decrescente pelo AttackPower)
            weaponlist.Sort();
            //
                foreach (Weapon item in weaponlist) {
                if (item != null) {
                    Console.WriteLine($"Attack power: {item.AttackPower}");
                    Console.WriteLine($"Durability: {item.Durability}");
                }
                }
            //
        }
    }
}
