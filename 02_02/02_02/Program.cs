using System;

namespace _02_02
{
    class Program
    {
        static void Main(string[] args) {
            //testar as cenas, delete later
            Console.WriteLine("Teste: ");
            Squad squad = new Squad();
            Unit unit1 = new Unit("Space Marine", new Vector2(1, 2), 100);
            squad.squadstack.Push(unit1);
            Unit unit2 = new Unit("Ripper", new Vector2(3, 4), 200);
            squad.squadstack.Push(unit2);
            Unit unit3 = new Unit("Healer", new Vector2(5, 6), 50);
            squad.squadstack.Push(unit3);
            Console.WriteLine("Estado da stack: ");
            foreach(object item in squad.squadstack) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
