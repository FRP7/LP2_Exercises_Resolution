using System;

namespace GameItems
{
    class Sword : GameItem
    {
        // Enum dos tipos de metal.
        public enum TypeofMetal {
            bronze,
            steel,
            aluminum
        }
        //
        // Enum do estado da espada.
        public enum WeaponCondition
        {
            broken,
            medium,
            fresh
        }
        //
        // Variável do nome, o new oculta a herança original.
        public new readonly string name;
        //
        // Variável da descrição, o new oculta a herança original.
        public new readonly string description;
        //
        // Variável da dimensão da espada.
        private int length { get; set; }
        //
        // Variável do enum TypeofMetal.
        private TypeofMetal typeofmetal;
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
            this.typeofmetal = typeofmetal;
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
