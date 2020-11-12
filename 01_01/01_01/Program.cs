using System;
using System.Collections.Generic;
namespace exercicio1
{
    class Program
    {
        // Valores do args convertidos para int
        private static float[] arraynumbers;
        //
        // Começar o programa
        private static void Main(string[] args) {
            // Definir o tamanho da arraynumbers
            arraynumbers = new float[args.Length];
            //
            // Guardar o args convertido para int na arraynumbers
            for (int i = 0; i < arraynumbers.Length; i++) {
                arraynumbers[i] = float.Parse(args[i]);
            }
            //
            // Ordenar os valores da arraynumbers por ordem crescente
            Array.Sort(arraynumbers);
            //
            // Chamar o método onde o user vai escolher os cálculos
            Options();
            //
        }
        //
        // Método onde o user vai escolher os cálculos
        private static void Options() {
            // A escolha do user
            string userChoice;
            //
            // Menu onde o user vai escolher os cálculos
            bool shut = false;
            while (shut == false) {
                Console.WriteLine("\n O que queres fazer? \n");
                Console.WriteLine("\n 1 - Obter média dos valores no array");
                Console.WriteLine("\n 2 - Obter mediana dos valores no array");
                Console.WriteLine("\n 3 - Obter moda dos valores no array");
                Console.WriteLine("\n 4 - Obter máximo dos valores no array");
                Console.WriteLine("\n 5 - Obter mínimo dos valores no_array");
                Console.WriteLine("\n 6 - Sair \n");
                userChoice = Console.ReadLine(); // Input do user
                if (userChoice == "1") {
                    Console.WriteLine("\n Média \n");
                    Console.WriteLine(Avg(0)); // Método para calcular a média
                } else if (userChoice == "2") {
                    Console.WriteLine("\n Mediana \n");
                    Console.WriteLine(Median(0)); // Método para calcular a mediana
                } else if (userChoice == "3") {
                    Console.WriteLine("\n Moda \n");
                    Console.WriteLine(Mode(0)); // Método para calcular a moda
                } else if (userChoice == "4") {
                    Console.WriteLine("\n Máximo \n");
                    Console.WriteLine(Max(0)); // Método para calcular o máximo
                } else if (userChoice == "5") {
                    Console.WriteLine("\n Mínimo \n");
                    Console.WriteLine(Min(0)); // Método para calcular o mínimo
                } else if (userChoice == "6") {
                    shut = true; // Sair
                } else {
                    Console.WriteLine("Tente de novo!"); // Caso erre
                }
            }
            //
        }
        //
        // Método para calcular a média
        private static float Avg(float x) {
            float avgresult;
            // Buscar a soma de todo o conteúdo da arraynumbers
            float sum = 0; // A soma total
            //Foreach para somar toda a arraynumbers
            foreach (float number in arraynumbers) {
                sum = sum + number;
            }
            //
            // Dividir a soma com o tamanho da arraynumbers
            avgresult = sum / arraynumbers.Length;
            //
            return avgresult;
        }
        //
        // Método para calcular a mediana
        private static float Median(float x) {
            float medianresult;
            if (arraynumbers.Length % 2 == 0) { // Verificar se é par
                // Verificar quais são os dois números no meio
                float midhigh = arraynumbers[arraynumbers.Length / 2];
                float midlow = arraynumbers[arraynumbers.Length / 2] - 1;
                //
                // Fazer a média desses dois números do meio
                medianresult = (midhigh + midlow) / arraynumbers.Length;
                //          
            } else { // Verificar se é ímpar
                // Verificar qual é o número do meio
                medianresult = arraynumbers[arraynumbers.Length / 2];
                //
            }
            return medianresult;
        }
        // Método para calcular a moda
        private static float Mode(float x) {
            float moderesult;
            /* Dicionário onde vai ser verificado cada número e o número 
             * de repetições de cada um
             */
            Dictionary<float, float> count = new Dictionary<float, float>();
            /*
             * Foreach para colocar os números como chaves e as respetivas
             * quantidades como valor.
             */
            foreach (float item in arraynumbers) {
                /* Se encontrar uma chave repetida, incrementa o valor
                 * dessa mesma chave
                 */
                if (count.ContainsKey(item)) {
                    count[item]++;
                } else {
                    /*
                     * Se não encontrar chave igual, coloca como chave
                     */
                    count.Add(item, 1);
                }
            }
            // Converter os valores do dicionário para array
            float[] order = new float[count.Count];
            count.Values.CopyTo(order, 0);
            // Ordenar a array por ordem crescente
            Array.Sort(order);
            // Buscar o valor que está no topo (que é o mais alto)
            float maxValue = order[order.Length - 1];
            // Procurar chave do valor máximo no dicionário
            moderesult = count[maxValue];
            return moderesult;
        }
        //
        // Método para calcular o máximo
        private static float Max(float x) {
            float maxresult;
            // Buscar o número que está no topo da array order
            maxresult = arraynumbers[arraynumbers.Length - 1];
            //
            return maxresult;
        }
        // Método para calcular o mínimo
        private static float Min(float x) {
            float minresult;
            // Buscar o número que está mais abaixo da array order
            minresult = arraynumbers
                [arraynumbers.Length - arraynumbers.Length];
            //
            return minresult;
        }
    }
}
