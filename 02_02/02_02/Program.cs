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

            ICollection<IUnit> units = new List<IUnit>();

            IUnit unit1 = new Unit("Soldier", new Vector2(5, 10), 100);
            IUnit unit2 = new Unit("Tank", new Vector2(15, 20), 200);
            IUnit unit3 = new Unit("Healer", new Vector2(25, 30), 300);

            units.Add(unit1);
            units.Add(unit2);
            units.Add(unit3);

            Squad squad = new Squad(units);

            squad.Teste();
        }
    }
    //
}
