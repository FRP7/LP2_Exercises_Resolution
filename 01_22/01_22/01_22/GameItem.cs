using System;

namespace _01_22
{
    public abstract class GameItem
    {
        // Variável do nome, não pode ser modificado excepto nos construtores.
        public readonly string name;
        // Variável da descrição, não pode ser modificado excepto nos construtores.
        public readonly string description;

        // Construtor que define os valores das variáveis
        public GameItem(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
