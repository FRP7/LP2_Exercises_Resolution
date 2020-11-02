using System;
namespace Checker
{
    class Checker
    {
        // Input do user
        private static string userinput;
        //
        // Altura da array
        private static int arrayheight;
        //
        // Comprimento da array
        private static int arraywidth;
        //
        // Valores que serão depois colocados na array final
        private static int[,] values;
        //
        // Array que vai ser utilizada para expor a array final
        private static int[,] print;
        //
        private static void Main(string[] args) {
            Console.WriteLine("Qual é a altura da array?");
            // Input do user
            userinput = Console.ReadLine();
            //
            // Converter o input para int e colocar na arrayheight
            arrayheight = Convert.ToInt32(userinput);
            //
            Console.WriteLine("Qual é o comprimento da array?");
            // Input do user
            userinput = Console.ReadLine();
            //
            // Converter o input para int e colocar na arraywidth
            arraywidth = Convert.ToInt32(userinput);
            //
            // Definir o tamanho da array values
            values = new int[arrayheight, arraywidth];
            //
            Console.WriteLine($"Tem {arrayheight * arraywidth} slots");
            // Pedir os valores e colocar na array values
            for (int x = 0; x < arrayheight; x++) {
                for (int y = 0; y < arraywidth; y++) {
                    Console.WriteLine("Insere um valor");
                    // Input do user
                    userinput = Console.ReadLine();
                    //
                    // Converter o input para int e colocar na array
                    values[x, y] = Convert.ToInt32(userinput);
                    //
                }
            }
            //
            Console.WriteLine("Qual é o valor que quer procurar?");
            // Input do user
            userinput = Console.ReadLine();
            //
            // Nova instância de Checker
            Checker _check;
            //
            // Verificar se o método Check() retoma true
            if (Check() == true) {
                Console.WriteLine("Existe linha");
            } else {
                Console.WriteLine("Não existe linha");
            }
            //
            // Mostrar a array
            PrintArray();
            //
        }
        /* Método para verificar se a array contêm uma linha com
         * quatro ou mais valores seguidos iguais aos que o user pede
         * para procurar.
         * Retoma true se encontrar.
         */
        private static bool Check() {
            // Definir o tamanho da array onde vai ser analisada
            int[,] x = new int[arrayheight, arraywidth];
            // Definir os valores da array x
            x = values;
            // Definir os valores da array de exposição
            print = x;
            // Converter para int o valor que o user quer que seja procurado
            int y = Convert.ToInt32(userinput);
            // Contar a quantidade de valores seguidos na array x
            int sum = 0;
            // Verificar se tem quatro valores seguidos
            bool isfour = false;
            // Index 
            int index = 0;
            // Verificar linhas horizontais
            for (int n = 0; n < x.GetLength(0); n++) {
                // Retoma a zero quando começa
                sum = default;
                //
                for (int j = 0; j < x.GetLength(1); j++) {
                    // Verificar se existe um valor igual ao que o user escolheu
                    if (x[n, j] == y) {
                        // Soma
                        sum++;
                        //
                    }
                }
                //
                // Verificar se existe quatro números seguidos
                if (sum >= 4) {
                    isfour = true;
                }
                //
            }
            //
            sum = default;
            /// Verificar linhas verticais 
            for (int j = 0; j < x.GetLength(1); j++) {
                // Retoma a zero quando começa
                sum = default;
                //
                for (int n = 0; n < x.GetLength(0); n++) {
                    // Verificar se existe um valor igual ao que o user escolheu
                    if (x[n, j] == y) {
                        // Soma
                        sum++;
                        //
                    }
                    //
                }
                // Verificar se existe quatro números seguidos
                if (sum >= 4) {
                    isfour = true;
                }
                //
            }
            ///
            sum = default;
            // Verificar linhas diagonais cima para baixo, esquerda para direita
            for (int n = 0; n < 1; n++) {
                for (int j = 0; j < x.GetLength(1); j++) {
                    // Verificar se existe um valor igual ao que o user escolheu
                    if (x[j, j] == y) {
                        // Soma
                        sum++;
                        //
                    }
                    //
                    // Verificar se existe quatro números seguidos
                    if (sum >= 4) {
                        isfour = true;
                    }
                    //
                }
            }
            //
            // Retomar a soma a zero
            sum = default;
            //
            // Verificar linhas diagonais cima para baixo, direita para esquerda
            for (int n = 0; n < 1; n++) {
                for (int j = x.GetLength(1) - 1; j >= 0; j--) {
                    // Verificar se existe um valor igual ao que o user escolheu
                    if (x[index, j] == y) {
                        sum++;
                    }
                    //
                    // Verificar se existe quatro números seguidos
                    if (sum >= 4) {
                        isfour = true;
                    }
                    //
                    //Incrementar o index
                    index++;
                    //
                }
            }
            //
            // Verificar se foi encontrado quatro valores seguidos 
            if (isfour == true) {
                return true;
            } else {
                return false;
            }
        }
        // Método para mostrar a array
        private static void PrintArray() {
            // Tamanho da linha
            int rowLength = print.GetLength(0);
            //
            // Tamanho da coluna
            int colLength = print.GetLength(1);
            //
            // Mostrar a array:
            string arrayString = "";
            //
            for (int i = 0; i < rowLength; i++) {
                for (int j = 0; j < colLength; j++) {
                    // Colocar os valores da array
                    arrayString += string.Format("{0} ", print[i, j]);
                    //
                }
                // Colocar nova linha
                arrayString += System.Environment.NewLine +
                    System.Environment.NewLine;
                //
            }
            // Mostrar a array
            Console.WriteLine(arrayString);
        }
        //
    }
}
