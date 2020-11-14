using System;

namespace _01_18
{
    public class Weapon : IComparable<Weapon>
    {
        // Poder de ataque.
        public float AttackPower { get; }

        // Durabilidade.
        public float Durability { get; }

        // Construtor que cria armas.
        public Weapon(float attackPower, float durability) {
            AttackPower = attackPower;
            Durability = durability;
        }

        /*  Definir que o Sort() vai ordenar por ordem decrescente 
         *  pelo AttackPower
         */
        public int CompareTo(Weapon weapon) {
            int returnValue = 0;
            if (weapon == null) {
                returnValue = 0;
            } else {
                if (AttackPower > weapon.AttackPower) {
                    returnValue = -1;
                } else if (AttackPower < weapon.AttackPower) {
                    returnValue = 1;
                } else {
                    returnValue = 0;
                }
            }
            return returnValue;
        }
    }
}
