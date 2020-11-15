using System;

namespace _01_09
{
    class Checker
    {
        private static void Main(string[] args) {
            // Input do user
            string userInput;

            // Número de linhas da array
            int arrayLines = 0;

            // Número de colunas da array
            int arrayColumns = 0;

            // Array final
            int[,] values;

            // Nova instância de Checker
            Checker _check;

            // Verificar se o número de linhas da matriz está definido
            bool isMatrixLine = false;

            // Verificar se o número de colunas da matriz está definido
            bool isMatrixColumn = false;

            // Verificar se os elementos estão preenchidos
            bool isValue = false;

            // O valor do input do user
            int value = 0;

            // Definir o número de linhas
            while (isMatrixLine == false) {
                Console.WriteLine("Qual é o número de linhas da matriz?");
                // User Input
                userInput = Console.ReadLine();

                // Tentar convertar o input para int
                if (Int32.TryParse(userInput, out arrayLines)) {
                    // Verificar se o número de linhas não é zero ou negativo.
                    if (arrayLines >= 1) {
                        isMatrixLine = true;
                    }
                    else {
                        Console.WriteLine("Valor inválido, tente de novo.");
                    }
                } else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }

            }

            // Definir o número de linhas
            while (isMatrixColumn == false) {
                Console.WriteLine("Qual é o número de colunas da matriz?");
                // User Input
                userInput = Console.ReadLine();

                // Tentar convertar o input para int
                if (Int32.TryParse(userInput, out arrayColumns)) {
                    // Verificar se o número de colunas não é zero ou negativo.
                    if (arrayColumns >= 1) {
                        isMatrixColumn = true;
                    } else {
                        Console.WriteLine("Valor inválido, tente de novo.");
                    }
                } else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }

            }

            // Definir o tamanho da array values
            values = new int[arrayLines, arrayColumns];

            Console.WriteLine($"Tem {arrayLines * arrayColumns} slots");
            // Pedir os valores e colocar na array values
            while (isValue == false) {
                for (int x = 0; x < arrayLines; x++) {
                    for (int y = 0; y < arrayColumns; y++) {
                        while (value == 0) {
                            Console.WriteLine($"Insere um valor na" +
                                $" linha {x + 1} na coluna {y + 1}");
                            // Input do user
                            userInput = Console.ReadLine();

                            /* Tentar converter o input para float
                             * e colocar na array */
                            if (Int32.TryParse(userInput, out value)) {
                                values[x, y] = value;
                                PrintArray(values);

                            } else {
                                Console.WriteLine
                                    ("Valor inválido, tente de novo");
                            }
                        }
                        value = default;
                    }
                    isValue = true;
                }
            }

            Console.WriteLine("Qual é o valor que quer procurar?");
            // Input do user
            userInput = Console.ReadLine();


            // Verificar se o método Check() retoma true
            //_check = new Checker(values, userInput);
            _check = new Checker();


            // Mostrar a array
            PrintArray(values);


            if (_check.Check(values, Convert.ToInt32(userInput)) == true) {
                Console.WriteLine("Existe linha");
            } else {
                Console.WriteLine("Não existe linha");
            }
        }
        /* Método para verificar se a array contêm uma linha com
         * quatro ou mais valores seguidos iguais aos que o user pede
         * para procurar.
         * Retoma true se encontrar.
         */
        private bool Check(int[,] x, int ui) {
            // Contar a quantidade de valores seguidos na array x
            int sum = 0;

            // Verificar se tem quatro valores seguidos
            bool isfour = false;


            // Verificar linhas horizontais
            for (int n = 0; n < x.GetLength(0); n++) {
                // Retoma a zero quando começa
                sum = default;

                for (int j = 0; j < x.GetLength(1); j++) {
                    /* Verificar se existe um valor igual ao que
                     * o user escolheu */
                    if (x[n, j] == ui) {
                        // Soma
                        sum++;
                    }
                }

                // Verificar se existe quatro números seguidos
                if (sum >= 4) {
                    isfour = true;
                }
            }

            sum = default;

            /// Verificar linhas verticais 
            for (int j = 0; j < x.GetLength(1); j++) {
                // Retoma a zero quando começa
                sum = default;

                for (int n = 0; n < x.GetLength(0); n++) {
                    /* Verificar se existe um valor igual ao que o 
                     * user escolheu */
                    if (x[n, j] == ui) {
                        // Soma
                        sum++;
                    }
                }
                // Verificar se existe quatro números seguidos
                if (sum >= 4) {
                    isfour = true;
                }
            }

            sum = default;

            /* Verificar linhas diagonais cima para baixo, 
             * esquerda para direita */
            for (int n = 0; n < 1; n++) {
                for (int z = 0; z < x.GetLength(0); z++) {
                    for (int j = 0; j < x.GetLength(1); j++) {
                        /* Verificar se existe um valor igual ao que o
                         * user escolheu */
                        if (x[z, j] == ui) {
                            // Soma
                            sum++;
                        }

                        // Verificar se existe quatro números seguidos
                        if (sum >= 4) {
                            isfour = true;
                        }
                    }
                }
            }

            // Retomar a soma a zero
            sum = default;

            /* Verificar linhas diagonais cima para baixo, direita para 
            esquerda*/
            for (int n = 0; n < 1; n++) {
                for (int z = 0; z < x.GetLength(0); z++) {
                    for (int j = x.GetLength(1) - 1; j >= 0; j--) {
                        /* Verificar se existe um valor igual ao que o user 
                        escolheu*/
                        if (x[z, j] == ui) {
                            sum++;
                        }

                        // Verificar se existe quatro números seguidos
                        if (sum >= 4) {
                            isfour = true;
                        }
                    }
                }
            }

            // Verificar se foi encontrado quatro valores seguidos 
            if (isfour == true) {
                return true;
            } else {
                return false;
            }
        }
        // Método para mostrar a array
        private static void PrintArray(int[,] val) {
            // Tamanho da linha
            int rowLength = val.GetLength(0);

            // Tamanho da coluna
            int colLength = val.GetLength(1);

            // Mostrar a array:
            string arrayString = "";

            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores da array
                    arrayString += string.Format("{0} ", val[i, j]);
                }
                // Colocar nova linha
                arrayString += System.Environment.NewLine +
                    System.Environment.NewLine;
            }
            // Mostrar a array
            Console.WriteLine(arrayString);
        }
    }
}
