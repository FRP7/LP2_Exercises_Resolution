using System;

namespace _02_02
{
    /// <summary>
    /// Classe para testar a solução.
    /// </summary>
    class Program
    {
        static void Main(string[] args) {
            // Aceder à classe Squad.
            Squad squad = new Squad();
            //
            // Aceder à subclasse SubSquad.
            SubSquad subsquad = new SubSquad();
            //
            // Construir units e adicionar às stacks da Squad e SubSquad.
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
            //

            // Mostrar no ecrã a squad.
            Console.WriteLine("Squad: ");
            foreach (object item in squad.squadstack) {
                Console.WriteLine(item.ToString());
            }
            //

            // Adicionar movimento à squad.
            Console.WriteLine("New squad position: ");
            squad.Move(new Vector2(1, 1));
            foreach (object item in squad.squadstack) {
                Console.WriteLine(item.ToString());
            }
            //

            // Mostrar no ecrã a subsquad.
            Console.WriteLine("Sub squad: ");
            foreach (object item in subsquad.subsquadstack) {
                Console.WriteLine(item.ToString());
            }
            //

            // Adicionar movimento à subsquad.
            Console.WriteLine("New sub squad position: ");
            subsquad.Move(new Vector2(1, 1));
            foreach (object item in subsquad.subsquadstack) {
                Console.WriteLine(item.ToString());
            }
            //
        }
    }
    //
}
