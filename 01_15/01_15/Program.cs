using System;

namespace _01_15
{
    class Program
    {
        static void Main(string[] args) {
            // Variável para aceder à struct Duration.
            Duration _duration = new Duration(1000000000);
            //
            // Mostrar no ecrã os valores.
            Console.WriteLine($"Segundos: {_duration.Seconds}");
            Console.WriteLine($"Minutos: {_duration.Minutes}");
            Console.WriteLine($"Horas: {_duration.Hours}");
            Console.WriteLine($"Dias: {_duration.Days}");
            Console.WriteLine($"Semanas: {_duration.Weeks}");
            Console.WriteLine($"Anos: {_duration.Years}");
            //
        }
    }
}
