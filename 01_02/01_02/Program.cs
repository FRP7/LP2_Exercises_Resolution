using System;

namespace _01_02
{
    class Program
    {
        // Matriz
        private static int[,] matrix { get; set; }
        // Vetor
        private static int[,] vector { get; set; }
        // Resultado final 
        private static int[,] result { get; set; }
        // Comprimento da matriz
        private static int matrixcolumns { get; set; }

        private static void Main(string[] args) {
            // Método para criar a matriz
            ConstructMatrix();
            // Método para criar o vetor
            ConstructVector();
            // Método para multiplicar a matriz com o vetor
            Multiply();
            // Método para somar a matriz
            Sum();
            // Método para expor o resultado
            PrintResult();
        }

        // Método para criar a matriz
        private static void ConstructMatrix() {
            // Input do user para definir o número de linhas
            string inputmatrixlines;
            // Número de linhas da matriz
            int matrixlines;
            // Input do user para definir o número de colunas da matriz
            string inputmatrixcolumns;

            // Definir o o número de linhas da matriz
            Console.WriteLine("Qual é o número de linhas da matriz?");
            // Input do user para definir o número de linhas
            inputmatrixlines = Console.ReadLine();
            // Converter o input para int
            matrixlines = Convert.ToInt32(inputmatrixlines);
            Console.WriteLine("Qual o número de colunas da matriz?");
            // Input do user para definir o número de colunas
            inputmatrixcolumns = Console.ReadLine();
            // Converter o input para int
            matrixcolumns = Convert.ToInt32(inputmatrixcolumns);
            // Criar a matriz
            matrix = new int[matrixlines, matrixcolumns];
            Console.WriteLine($"A matriz tem {matrix.Length} casas");
            //

            // Definir os valores
            // Input do user
            string userinput;
            // Valor
            int value;

            // Preencher os valores
            for (int j = 0; j < matrixlines; j++) {
                for (int i = 0; i < matrixcolumns; i++) {
                    Console.WriteLine("Insere um número: ");
                    // User input do valor
                    userinput = Console.ReadLine();
                    // Converter o input para int
                    value = Convert.ToInt32(userinput);
                    // Colocar na linha
                    matrix[j, i] = value;
                }
            }
            //
            //
        }
        //

        // Método para criar o vetor
        private static void ConstructVector() {
            // Criar o vetor
            vector = new int[matrixcolumns, 1];
            Console.WriteLine($"O vector tem {vector.Length} casas");
            //

            // Definir os valores
            // Input do user
            string userinput;
            // Valor
            int value;

            // Preencher os valores
            for (int i = 0; i < matrixcolumns; i++) {
                Console.WriteLine("Insere um número: ");
                // Input do user do valor
                userinput = Console.ReadLine();
                // Converter o input para int
                value = Convert.ToInt32(userinput);
                // Colocar na linha
                vector[i, 0] = value;
            }
            //
        }
        //

        // Método para multiplicar a matriz com o vetor
        private static void Multiply() {
            Console.WriteLine("Calculate...");
            // Index do vetor
            int vectorindex = 0;

            // Multiplicar os valores da matriz com o vetor
            for (int n = 0; n < matrix.GetLength(0); n++) {
                for (int i = 0; i < matrix.GetLength(1); i++) {
                    for (int j = 0; i < vector.GetLength(0); i++) {
                        matrix[n, i] = matrix[n, i]
                            * vector[vectorindex, 0];
                        vectorindex++;
                    }

                }
                // Voltar o index do vetor a zero
                vectorindex = default;
            }
            //
        }
        //

        // Método para somar os valores da matriz
        private static void Sum() {
            // Definir o tamanho do result
            result = new int[matrix.GetLength(0), 1];
            // Guardar soma para meter no result
            int sum;

            // Somar os valores da matriz
            for (int j = 0; j < matrix.GetLength(0); j++) {
                // Voltar a soma a zero
                sum = default;
                for (int i = 0; i < matrix.GetLength(1); i++) {
                    sum = sum + matrix[j, i];
                }
                // Colocar na linha
                result[j, 0] = sum;
            }
            //
        }
        //

        // Método para mostrar o resultado 
        private static void PrintResult() {
            // Tamanho da linha
            int rowLength = result.GetLength(0);
            // Tamanho da coluna
            int colLength = result.GetLength(1);
            // Resultado
            string resultstring = "";

            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores de result
                    resultstring += result[i, j].ToString();
                }
                // Colocar nova linha 
                resultstring += Environment.NewLine + Environment.NewLine;
            }
            // Mostrar resultado
            Console.WriteLine(resultstring);
        }
        //
    }
}
