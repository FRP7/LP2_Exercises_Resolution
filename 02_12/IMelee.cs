using System;

namespace _02_12
{
    interface IMelee
    {
        // Attacks return true if they hit opponent
        bool AttackFromAbove();
        bool AttackFromBelow();
        bool AttackFromTheLeft();
        bool AttackFromTheRight();
    }
}
