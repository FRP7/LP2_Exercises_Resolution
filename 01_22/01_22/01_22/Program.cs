﻿using System;

namespace _01_22
{
    class Program
    {
        // Variável da classe GameItem
        private static GameItem _gameitem;
        //

        static void Main(string[] args)
        {
            // Chamar o construtor e definir os valores
            _gameitem = new Sword(name: "Sword of king Arthur",
                description: "One of the most important swords in history",
                length: 50, typeofmetal: TypeofMetal.steel,
                condition: WeaponCondition.fresh);
            //
        }
    }
}

