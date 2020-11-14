using System;
using System.Collections.Generic;

namespace _01_18
{
    public class CompareWeapon : IComparer<Weapon>
    {
        // Definir que o Sort() ordena por ordem crescente pela Durability
        public int Compare(Weapon a, Weapon b) {
            int returnValue = 0;

            if (a == null | b == null) {
                returnValue = 0;
            } else if (a == null && b == null) {
                returnValue = 0;
            } else {
                if (a.Durability > b.Durability) {
                    returnValue = 1;
                } else if (a.Durability < b.Durability) {
                    returnValue = -1;
                } else {
                    returnValue = 0;
                }
            }
            return returnValue;
        }
    }
}
