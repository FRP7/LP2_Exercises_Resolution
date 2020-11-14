using System;

namespace _01_18
{
    public class Weapon : IComparable<Weapon>
    {
        // Variável da AttackPower (só de leitura excepto no construtor).
        public float AttackPower { get; }
        //
        // Variável da Durability (só de leitura excepto no construtor).
        public float Durability { get; }
        //

        // Construtor que cria armas.
        public Weapon(float attackPower, float durability)
        {
            AttackPower = attackPower;
            Durability = durability;
        }
        //

        /*  Definir que o Sort() vai ordenar por ordem decrescente 
         *  pelo AttackPower
         */
        public int CompareTo(Weapon weapon)
        {
            int returnvalue = 0;
            if (weapon == null) {
                returnvalue = 1;
            } else {
                if (AttackPower > weapon.AttackPower) {
                    returnvalue = -1;
                } else if (AttackPower < weapon.AttackPower) {
                    returnvalue = 1;
                } else {
                    returnvalue = 0;
                }
            }
            return returnvalue;
        }
        //
    }
}
