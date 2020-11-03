using System;

namespace _01_22
{
    class Sword : GameItem
    {
        // Variável do nome
        public readonly string name;
        //
        // Variável da descrição
        public readonly string description;
        //
        // Variável da dimensão da espada.
        private int length { get; set; }
        //
        // Variável do enum TypeofMetal.
        private TypeofMetal typeOfMetal;
        //
        // Variável do enum WeaponCondition.
        private WeaponCondition condition;
        //

        /* Construtor que define os valores das variáveis e 
         * depois mostra no ecrã 
         */
        public Sword(string name, string description,
            int length, TypeofMetal typeofmetal, WeaponCondition condition)
            : base(name, description)
        {
            this.name = name;
            this.description = description;
            this.description = description;
            this.length = length;
            this.typeOfMetal = typeofmetal;
            this.condition = condition;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Type of metal: {typeofmetal}");
            Console.WriteLine($"Condition: {condition}");
        }
        //
    }
}
