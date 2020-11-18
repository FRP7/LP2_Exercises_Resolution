using System;

namespace _02_12
{
    class Program
    {
        static void Main(string[] args) {
            IWeapon weapon1 = new MeleeAdapter(new Knife());
        }
    }
}
