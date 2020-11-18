using System;
using System.Collections.Generic;
using System.Text;

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
