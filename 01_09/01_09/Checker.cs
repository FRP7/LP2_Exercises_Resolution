using System;
namespace Checker
{
    class Checker
    {
        // Input do user
        private static string userinput;
        //
        // Número de linhas da array
        private static int arraylines;
        //
        // Número de colunas da array
        private static int arraycolumns;
        //
        // Valores que serão depois colocados na array final
        private static int[,] values;
        //
        // Array que vai ser utilizada para expor a array final
        private static int[,] print;
        //

        public Checker() {
            // Verificar se o método Check() retoma true
            if (Check() == true) {
                Console.WriteLine("Existe linha");
            } else {
                Console.WriteLine("Não existe linha");
            }
            //
        }
        private static void Main(string[] args) {
            // Nova instância de Checker
            Checker _check;
            //
            bool ismatrixline = false;
            bool ismatrixcolumn = false;
            bool isvalue = false;
            int value = 0;

            // Definir o número de linhas
            while (ismatrixline == false) {
                Console.WriteLine("Qual é o número de linhas da matriz?");
                // User Input
                userinput = Console.ReadLine();
                //
                // Tentar convertar o input para int
                if (Int32.TryParse(userinput, out arraylines)) {
                    ismatrixline = true;
                } else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }
                //
            }
            //

            // Definir o número de linhas
            while (ismatrixcolumn == false) {
                Console.WriteLine("Qual é o número de colunas da matriz?");
                // User Input
                userinput = Console.ReadLine();
                //
                // Tentar convertar o input para int
                if (Int32.TryParse(userinput, out arraycolumns)) {
                    ismatrixcolumn = true;
                } else {
                    Console.WriteLine("Valor inválido, tente de novo.");
                }
                //
            }
            //

            // Definir o tamanho da array values
            values = new int[arraylines, arraycolumns];
            //

            Console.WriteLine($"Tem {arraylines * arraycolumns} slots");
            // Pedir os valores e colocar na array values
            while (isvalue == false) {
                for (int x = 0; x < arraylines; x++) {
                    for (int y = 0; y < arraycolumns; y++) {
                        while (value == 0) {
                            Console.WriteLine("Insere um valor");
                            // Input do user
                            userinput = Console.ReadLine();
                            //
                            // Converter o input para int e colocar na array
                            if (Int32.TryParse(userinput, out value)) {
                                values[x, y] = value;
                                //
                            }
                            else {
                                Console.WriteLine
                                    ("Valor inválido, tente de novo");
                            }
                        }
                        value = default;
                    }
                    isvalue = true;
                }
            }
            //
            Console.WriteLine("Qual é o valor que quer procurar?");
            // Input do user
            userinput = Console.ReadLine();
            //

            // Verificar se o método Check() retoma true
            _check = new Checker();
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
        private bool Check() {
            // Definir o tamanho da array onde vai ser analisada
            int[,] x = new int[arraylines, arraycolumns];
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
                    /* Verificar se existe um valor igual ao que
                     * o user escolheu */
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
                    /* Verificar se existe um valor igual ao que o 
                     * user escolheu */
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
            /* Verificar linhas diagonais cima para baixo, 
             * esquerda para direita */
            for (int n = 0; n < 1; n++) {
                for(int z = 0; z < x.GetLength(0); z++) {
                    for (int j = 0; j < x.GetLength(1); j++) {
                        /* Verificar se existe um valor igual ao que o
                         * user escolheu */
                        if (x[z, j] == y) {
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
            }
            //
            // Retomar a soma a zero
            sum = default;
            //
            /* Verificar linhas diagonais cima para baixo, direita para 
            esquerda*/
            for (int n = 0; n < 1; n++) {
                for (int z = 0; z < x.GetLength(0); z++) {
                    for (int j = x.GetLength(1) - 1; j >= 0; j--) {
                        /* Verificar se existe um valor igual ao que o user 
                        escolheu*/
                        if (x[z, j] == y) {
                            sum++;
                        }
                        //
                        // Verificar se existe quatro números seguidos
                        if (sum >= 4) {
                            isfour = true;
                        }
                        //
                    }
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
