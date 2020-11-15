using System;

namespace _01_02
{
    class Program
    {
        // Matriz
        private static float[,] Matrix { get; set; }

        // Vetor
        private static float[,] Vector { get; set; }

        // Resultado final 
        private static float[,] Result { get; set; }

        // Número de colunas da matriz
        private static int MatrixColumns { get; set; }

        // Número de linhas da matriz
        private static int MatrixLines { get; set; }


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
            string inputMatrixLines;

            // Input do user para definir o número de colunas da matriz
            string inputMatrixColumns;

            // Verificar se ficou definido o número de linhas da matriz.
            bool isMatrixLines = false;

            // Verificar se ficou definido o número de colunas da matriz.
            bool isMatrixColumns = false;

            // Número de linhas da matriz.
            int matrixLineValue;

            // Número de colunas da matriz
            int matrixColumnValue;

            // Input do user
            string userInputValue;

            // Valor dos elementos
            float value = 0f;

            // Verificar se os elementos estão preenchidos
            bool isValue = false;

            // Verificar se foi colocado um elemento.
            bool isAdded = false;


            // Definir o número de linhas
            while (isMatrixLines == false) {
                Console.WriteLine("Qual é o número de linhas da matriz?");

                // User Input
                inputMatrixLines = Console.ReadLine();

                // Tentar convertar o input para int
                if (Int32.TryParse(inputMatrixLines, out matrixLineValue)) {
                    // Verificar se o input não é zero.
                    if (matrixLineValue >= 1) {
                        MatrixLines = matrixLineValue;
                        isMatrixLines = true;
                    } else {
                        Console.WriteLine("Valor inválido, tente de novo.");
                    }
                } else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }
            }
            

            // Definir o número de colunas
            while (isMatrixColumns == false) {
                Console.WriteLine("Qual é o número de colunas da matriz?");

                // User input
                inputMatrixColumns = Console.ReadLine();

                // Tentar converter o input para int
                if (Int32.TryParse(inputMatrixColumns,out matrixColumnValue)) {
                    if (matrixColumnValue >= 1) {
                        MatrixColumns = matrixColumnValue;
                        isMatrixColumns = true;
                    }
                    else {
                        Console.WriteLine("Valor inválido, tente de novo.");
                    }
                } else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }
            }

            // Colocar o número de linhas e colunas na matriz
            Matrix = new float[MatrixLines, MatrixColumns];
        
            Console.WriteLine($"A matriz tem {Matrix.Length} elementos");

            // Definir os valores
            while (isValue == false) {
                for (int j = 0; j < MatrixLines; j++) {
                    for (int i = 0; i < MatrixColumns; i++) {
                        while (isAdded == false) {
                            Console.WriteLine($"Insere um número na linha" +
                                $" {j + 1} na coluna {i + 1}: ");
                            if (j == 0 && i == 0) {
                                // Mostrar matriz 
                                PrintMatrix();
                            }
                            // User input do valor
                            userInputValue = Console.ReadLine();

                            // Tentar converter o input para float
                            if (float.TryParse(userInputValue, out value)) {
                                // Colocar na linha
                                Matrix[j, i] = value;

                                // Mostrar matriz
                                PrintMatrix();

                                isAdded = true;
                            } else {
                                Console.WriteLine("Valor inválido, " +
                                    "tente de novo");
                            }
                        }
                        isAdded = false;
                    }
                    isValue = true;
                }
            }
        }

        // Método para criar o vetor
        private static void ConstructVector() {
            // Criar o vetor
            Vector = new float[MatrixColumns, 1];
            Console.WriteLine($"O vector tem {Vector.Length} elementos");

            // Definir os valores
            // Input do user
            string userInput;

            // Valor
            float value = 0f;

            // Verificar se foi inserido algum valor
            bool isAdded = false;
 
            for (int i = 0; i < MatrixColumns; i++) {
                while (isAdded == false) {
                    Console.WriteLine($"Insere um número na linha " +
                        $"{i + 1} na coluna 1: ");
                    if (i == 0) {
                        // Mostrar vector
                        PrintVector();
                        
                    }
                    // Input do user do valor
                    userInput = Console.ReadLine();

                    // Converter o input para int
                    if (float.TryParse(userInput, out value)) {
                        value = float.Parse(userInput);
                        // Colocar na linha
                        Vector[i, 0] = value;
                        
                        // Mostrar vector
                        PrintVector();
                        
                        isAdded = true;
                    } else {
                        Console.WriteLine("Valor inválido, tente de novo");
                    }
                }
                isAdded = false;
            }
        }

        // Método para multiplicar a matriz com o vetor
        private static void Multiply() {
            Console.WriteLine("Calculate...");

            // Index do vetor
            int vectorIndex = 0;

            // Multiplicar os valores da matriz com o vetor
            for (int n = 0; n < Matrix.GetLength(0); n++) {
                for (int i = 0; i < Matrix.GetLength(1); i++) {
                    while (i < Vector.GetLength(0)) {
                        Matrix[n, i] = Matrix[n, i]
                                * Vector[vectorIndex, 0];
                        vectorIndex++;
                        i++;
                    }
                }
                vectorIndex = default;
            }
        }

        // Método para somar os valores da matriz
        private static void Sum() {
            // Definir o tamanho do result
            Result = new float[Matrix.GetLength(0), 1];

            // Guardar soma para meter no result
            float sum;

            // Somar os valores da matriz
            for (int j = 0; j < Matrix.GetLength(0); j++) {
                sum = default;
                for (int i = 0; i < Matrix.GetLength(1); i++) {
                    sum = sum + Matrix[j, i];
                }
                // Colocar na linha
                Result[j, 0] = sum;
            }
        }

        // Método para mostrar o resultado 
        private static void PrintResult() {
            // Tamanho da linha
            int rowLength = Result.GetLength(0);
            
            // Tamanho da coluna
            int colLength = Result.GetLength(1);
            
            // Resultado
            string resultString = "";
            
            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores de result
                    resultString += Result[i, j].ToString();
                }
                // Colocar nova linha 
                resultString += Environment.NewLine + Environment.NewLine;
            }
            // Mostrar resultado
            Console.WriteLine("Resultado:");
            Console.WriteLine(resultString);
            
        }

        // Método para mostrar a matriz 
        private static void PrintMatrix() {
            // Tamanho da linha
            int rowLength = Matrix.GetLength(0);
            
            // Tamanho da coluna
            int colLength = Matrix.GetLength(1);
            
            // Resultado
            string matrixString = "";
            

            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores de result
                    matrixString += Matrix[i, j].ToString() + " ";           
                }
                // Colocar nova linha 
                matrixString += Environment.NewLine + Environment.NewLine;
                
            }
            // Mostrar resultado
            Console.WriteLine("Matriz: ");
            Console.WriteLine(matrixString);          
        }

        // Método para mostrar o vector 
        private static void PrintVector() {
            // Tamanho da linha
            int rowLength = Vector.GetLength(0);
            
            // Tamanho da coluna
            int colLength = Vector.GetLength(1);
            
            // Resultado
            string matrixString = "";
            

            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores de result
                    matrixString += Vector[i, j].ToString() + " ";                   
                }
                // Colocar nova linha 
                matrixString += Environment.NewLine + Environment.NewLine;                
            }
            // Mostrar resultado
            Console.WriteLine("Vector: ");
            Console.WriteLine(matrixString);
        }
    }
}
