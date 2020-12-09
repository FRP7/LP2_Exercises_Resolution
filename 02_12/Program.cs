using System;

namespace _02_12
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            IWeapon knife = new MeleeAdapter(new Knife(), true);
            knife.SwitchFireMode();
            knife.Shoot();
            knife.Reload();
            knife.Shoot();
        }
    }
}
