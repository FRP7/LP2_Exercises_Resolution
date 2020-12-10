using System;
using System.Collections.Generic;

namespace _02_02
{
    /// <summary>
    /// Classe para testar a solução.
    /// </summary>
    class Program
    {
        static void Main(string[] args) {

            // Coleção de soldados que quero formar batalhão.
            ICollection<IUnit> units = new List<IUnit>();

            // Criar soldados.
            IUnit unit1 = new Unit("Soldier", new Vector2(5, 10), 100);
            IUnit unit2 = new Unit("Tank", new Vector2(15, 20), 200);
            IUnit unit3 = new Unit("Healer", new Vector2(25, 30), 300);

            // Adicionar os soldados à coleção.
            units.Add(unit1);
            units.Add(unit2);
            units.Add(unit3);

            // Construir o batalhão.
            Squad squad = new Squad(units);
        }
    }
    //
}
