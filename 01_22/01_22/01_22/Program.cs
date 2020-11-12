using System;

namespace _01_22
{
    class Program
    {
        // Variável da classe GameItem
        //private static GameItem _Gameitem;
        //
                                                                               
        static void Main(string[] args)
        {
            // Chamar o construtor e definir os valores
            GameItem gameitem = new Sword("Sword of king Arthur",
                "One of the most important swords in history",
                50, TypeofMetal.steel, WeaponCondition.fresh);
            //
        }
    }
}

