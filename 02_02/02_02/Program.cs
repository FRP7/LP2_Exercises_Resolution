using System;

namespace _02_02
{
    class Program
    {
        static void Main(string[] args) {
            Squad squad = new Squad();
            SubSquad subsquad = new SubSquad();
            Unit unit1 = new Unit("Space Marine", new Vector2(1, 2), 100);
            squad.squadstack.Push(unit1);
            subsquad.subsquadstack.Push(unit1);
            Unit unit2 = new Unit("Space Marine", new Vector2(3, 4), 100);
            squad.squadstack.Push(unit2);
            subsquad.subsquadstack.Push(unit2);
            Unit unit3 = new Unit("Ripper", new Vector2(3, 4), 200);
            squad.squadstack.Push(unit3);
            Unit unit4 = new Unit("Healer", new Vector2(5, 6), 50);
            squad.squadstack.Push(unit4);

            Console.WriteLine("Squad: ");
            foreach (object item in squad.squadstack) {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("New squad position: ");
            squad.Move(new Vector2(1, 1));
            foreach (object item in squad.squadstack) {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Sub squad: ");
            foreach (object item in subsquad.subsquadstack) {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("New sub squad position: ");
            subsquad.Move(new Vector2(1, 1));
            foreach (object item in subsquad.subsquadstack) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
