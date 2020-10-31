using System;
using System.Collections.Generic;

namespace Weapon
{
    public class Weapon : IComparable<Weapon>
    {
        // Variável da AttackPower (só de leitura excepto no construtor).
        public float AttackPower { get; }
        //
        // Variável da Durability (só de leitura excepto no construtor).
        public float Durability { get; }
        //
        // Variável do nome da arma (só de leitura excepto no construtor).
        public string Name { get; }
        //

        // Construtor que cria armas.
        public Weapon(string name, float attackPower, float durability) {
            AttackPower = attackPower;
            Durability = durability;
            Name = name;
        }
        //

        /*  Definir que o Sort() vai ordenar por ordem decrescente 
         *  pelo AttackPower
         */
        public int CompareTo(Weapon _weapon) {
            int returnvalue = 0;
            if(this.AttackPower > _weapon.AttackPower) {
                returnvalue = -1;
            }
            else if(this.AttackPower < _weapon.AttackPower) {
                returnvalue = 1;
            }
            else {
                returnvalue = 0;
            }
            return returnvalue;
        }
        //
    }
}
