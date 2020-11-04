using System;

namespace _01_15
{
    class Program
    {
        // Variável para aceder à struct Duration.
        private static Duration _duration = new Duration();

        static void Main(string[] args) {
            // Chamar o método que gera os valores aleatórios.
            _duration.InsertTime();
            // Mostrar no ecrã os valores.
            Console.WriteLine($"Segundos: {_duration.Seconds}");
            Console.WriteLine($"Minutos: {_duration.Minutes}");
            Console.WriteLine($"Horas: {_duration.Hours}");
            Console.WriteLine($"Dias: {_duration.Days}");
            Console.WriteLine($"Semanas: {_duration.Weeks}");
            Console.WriteLine($"Anos: {_duration.Years}");
        }
    }
}
