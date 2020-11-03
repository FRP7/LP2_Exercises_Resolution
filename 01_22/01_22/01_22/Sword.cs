using System;

namespace _01_22
{
    class Sword : GameItem
    {
        // Variável do nome, o new oculta a herança original.
        public new readonly string Name;
        //
        // Variável da descrição, o new oculta a herança original.
        public new readonly string Description;
        //
        // Variável da dimensão da espada.
        private int Length { get; set; }
        //
        // Variável do enum TypeofMetal.
        private TypeofMetal _Typeofmetal;
        //
        // Variável do enum WeaponCondition.
        private WeaponCondition _Condition;
        //

        /* Construtor que define os valores das variáveis e 
         * depois mostra no ecrã 
         */
        public Sword(string name, string description,
            int length, TypeofMetal typeofmetal, WeaponCondition condition)
            : base(name, description)
        {
            this.Name = name;
            this.Description = description;
            this.Description = description;
            this.Length = length;
            this._Typeofmetal = typeofmetal;
            this._Condition = condition;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Type of metal: {typeofmetal}");
            Console.WriteLine($"Condition: {condition}");
        }
        //
    }
}
