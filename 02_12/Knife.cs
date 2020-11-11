using System;
using System.Collections.Generic;
using System.Text;

namespace _02_12
{
    class Knife : Weapon, IMelee
    {
        // Attacks return true if they hit opponent
        public bool AttackFromAbove() {
            return true;
        }
        public bool AttackFromBelow() {
            return true;
        }
        public bool AttackFromTheLeft() {
            return true;
        }
        public bool AttackFromTheRight() {
            return true;
        }
    }
}
