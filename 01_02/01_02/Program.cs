using System;

namespace _01_02
{
    class Program
    {
        // Matriz
        private static float[,] matrix { get; set; }
        //
        // Vetor
        private static float[,] vector { get; set; }
        //
        // Resultado final 
        private static float[,] result { get; set; }
        //
        // Número de colunas da matriz
        private static int matrixcolumns { get; set; }
        //
        // Número de linhas da matriz
        private static int matrixlines { get; set; }
        //

        private static void Main(string[] args) {
            // Método para criar a matriz
            ConstructMatrix();
            //
            // Método para criar o vetor
            ConstructVector();
            //
            // Método para multiplicar a matriz com o vetor
            Multiply();
            //
            // Método para somar a matriz
            Sum();
            //
            // Método para expor o resultado
            PrintResult();
            //
        }

        // Método para criar a matriz
        private static void ConstructMatrix() {
            // Input do user para definir o número de linhas
            string inputmatrixlines;
            //
            // Input do user para definir o número de colunas da matriz
            string inputmatrixcolumns;
            //

            // Verificar se ficou definido o número de linhas da matriz.
            bool ismatrixlines = false;
            //
            // Verificar se ficou definido o número de colunas da matriz.
            bool ismatrixcolumns = false;
            //

            // Número de linhas da matriz.
            int matrixlinevalue;
            //
            // Número de colunas da matriz
            int matrixcolumnvalue;
            //

            // Input do user
            string userinputvalue;
            //
            // Valor dos elementos
            float value = 0f;
            //
            // Verificar se os elementos estão preenchidos
            bool isvalue = false;
            //
            // Verificar se foi colocado um elemento.
            bool isAdded = false;
            //

            // Definir o número de linhas
            while (ismatrixlines == false) {
                Console.WriteLine("Qual é o número de linhas da matriz?");
                // User Input
                inputmatrixlines = Console.ReadLine();
                //
                // Tentar convertar o input para int
                if(Int32.TryParse(inputmatrixlines, out matrixlinevalue)) {
                    matrixlines = matrixlinevalue;
                    ismatrixlines = true;
                }
                else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }
                //
            }
            //

            // Definir o número de colunas
            while (ismatrixcolumns == false) {
                Console.WriteLine("Qual é o número de colunas da matriz?");
                // User input
                inputmatrixcolumns = Console.ReadLine();
                // Tentar converter o input para int
                if (Int32.TryParse(inputmatrixcolumns, 
                    out matrixcolumnvalue)) {
                    matrixcolumns = matrixcolumnvalue;
                    ismatrixcolumns = true;
                } else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }
                //
            }
            //

            // Colocar o número de linhas e colunas na matriz
            matrix = new float[matrixlines, matrixcolumns];
            //
            Console.WriteLine($"A matriz tem {matrix.Length} elementos");

            // Definir os valores
            while(isvalue == false) {
                for (int j = 0; j < matrixlines; j++) {
                    for (int i = 0; i < matrixcolumns; i++) {
                        while (isAdded == false) {
                            Console.WriteLine($"Insere um número na linha" +
                                $" {j + 1} na coluna {i + 1}: ");
                            if (j == 0 && i == 0) {
                                // Mostrar matriz 
                                PrintMatrix();
                                //
                            }
                            // User input do valor
                            userinputvalue = Console.ReadLine();
                            //
                            // Tentar converter o input para float
                            if (float.TryParse(userinputvalue, out value)) {
                                // Colocar na linha
                                matrix[j, i] = value;
                                //
                                // Mostrar matriz
                                PrintMatrix();
                                //
                                isAdded = true;
                            } else {
                                Console.WriteLine
                                    ("Valor inválido, tente de novo");
                            }
                            //
                        }
                        isAdded = false;
                    }
                    isvalue = true;
                }
            }
            //
        }
        //

        // Método para criar o vetor
        private static void ConstructVector() {
            // Criar o vetor
                vector = new float[matrixcolumns, 1];
            Console.WriteLine($"O vector tem {vector.Length} elementos");
            //

            // Definir os valores
            // Input do user
            string userinput;
            //
            // Valor
            float value = 0f;
            //
            // Verificar se foi inserido algum valor
            bool isAdded = false;
            //
                for (int i = 0; i < matrixcolumns; i++) {
                    while (isAdded == false) {
                        Console.WriteLine($"Insere um número na linha " +
                            $"{i + 1} na coluna 1: ");
                        if (i == 0) {
                            // Mostrar vector
                            PrintVector();
                            //
                        }
                        // Input do user do valor
                        userinput = Console.ReadLine();
                        // Converter o input para int
                        if (float.TryParse(userinput, out value)) {
                            value = float.Parse(userinput);
                            // Colocar na linha
                            vector[i, 0] = value;
                            //
                            // Mostrar vector
                            PrintVector();
                            //
                            isAdded = true;
                        } else {
                            Console.WriteLine("Valor inválido, tente de novo");
                        }
                        //
                    }
                    isAdded = false;
                }
            //
        }
        //

        // Método para multiplicar a matriz com o vetor
        private static void Multiply() {
            Console.WriteLine("Calculate...");
            // Index do vetor
            int vectorindex = 0;
            //

            // Multiplicar os valores da matriz com o vetor
                for (int n = 0; n < matrix.GetLength(0); n++) {
                    for (int i = 0; i < matrix.GetLength(1); i++) {
                        for (int j = 0; i < vector.GetLength(0); i++) {
                            matrix[n, i] = matrix[n, i]
                                * vector[vectorindex, 0];
                            vectorindex++;
                        }

                    }
                    vectorindex = default;
                //
            }
        }
        //

        // Método para somar os valores da matriz
        private static void Sum() {
            // Definir o tamanho do result
                result = new float[matrix.GetLength(0), 1];
            //
            // Guardar soma para meter no result
            float sum;
            //

                // Somar os valores da matriz
                for (int j = 0; j < matrix.GetLength(0); j++) {
                    sum = default;
                    for (int i = 0; i < matrix.GetLength(1); i++) {
                        sum = sum + matrix[j, i];
                    }
                    // Colocar na linha
                    result[j, 0] = sum;
                   //
                }
                //
        }
        //

        // Método para mostrar o resultado 
        private static void PrintResult() {
            // Tamanho da linha
            int rowLength = result.GetLength(0);
            //
            // Tamanho da coluna
            int colLength = result.GetLength(1);
            //
            // Resultado
            string resultstring = "";
            //

            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores de result
                    resultstring += result[i, j].ToString();
                    //
                }
                // Colocar nova linha 
                resultstring += Environment.NewLine + Environment.NewLine;
                //
            }
            // Mostrar resultado
            Console.WriteLine("Resultado:");
            Console.WriteLine(resultstring);
            //
        }
        //

        // Método para mostrar a matriz 
        private static void PrintMatrix() {
            // Tamanho da linha
            int rowLength = matrix.GetLength(0);
            //
            // Tamanho da coluna
            int colLength = matrix.GetLength(1);
            //
            // Resultado
            string matrixstring = "";
            //

            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores de result
                    matrixstring += matrix[i, j].ToString() + " ";
                    //
                }
                // Colocar nova linha 
                matrixstring += Environment.NewLine + Environment.NewLine;
                //
            }
            // Mostrar resultado
            Console.WriteLine("Matriz: ");
            Console.WriteLine(matrixstring);
            //
        }
        //

        // Método para mostrar o vector 
        private static void PrintVector() {
            // Tamanho da linha
            int rowLength = vector.GetLength(0);
            //
            // Tamanho da coluna
            int colLength = vector.GetLength(1);
            //
            // Resultado
            string matrixstring = "";
            //

            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores de result
                    matrixstring += vector[i, j].ToString() + " ";
                    //
                }
                // Colocar nova linha 
                matrixstring += Environment.NewLine + Environment.NewLine;
                //
            }
            // Mostrar resultado
            Console.WriteLine("Vector: ");
            Console.WriteLine(matrixstring);
            //
        }
        //
    }
}
