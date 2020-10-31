using System;
using System.Collections.Generic;

namespace Weapon
{
    public class Sort : IComparer<Weapon>
    {
        // Definir que o Sort() ordena por ordem crescente pela Durability
        public int Compare(Weapon a, Weapon b) {
            int returnvalue = 0;
            if(a.Durability > b.Durability) {
                returnvalue = 1;
            }
            else if(a.Durability < b.Durability) {
                returnvalue = -1;
            }
            else {
                returnvalue = 0;
            }
            return returnvalue;
        }
        //
    }
}
