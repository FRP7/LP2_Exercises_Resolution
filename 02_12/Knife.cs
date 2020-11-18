using System;
using System.Collections.Generic;
using System.Text;

namespace _02_12
{
    class Knife : IMelee
    {
        // Attacks return true if they hit opponent
        public bool AttackFromAbove() {
            Console.WriteLine("Attack from above!");
            return true;
        }
        public bool AttackFromBelow() {
            Console.WriteLine("Attack from below!");
            return true;
        }
        public bool AttackFromTheLeft() {
            Console.WriteLine("Attack from the left!");
            return true;
        }
        public bool AttackFromTheRight() {
            Console.WriteLine("Attack from the right!");
            return true;
        }
    }
}
