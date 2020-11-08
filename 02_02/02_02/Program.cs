using System;

namespace _02_02
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Teste: ");
            Unit unit1 = new Unit("Space Marine", new Vector2(1, 2), 100);
            Unit unit2 = new Unit("Ripper", new Vector2(3, 4), 200);
            Unit unit3 = new Unit("Healer", new Vector2(5, 6), 50);
        }
    }
}
