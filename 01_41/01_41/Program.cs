using System;

namespace _01_41
{
    class Program
    {
        static void Main(string[] args) {
            // Quantidade de elementos que o user quer colocar.
            int inputnumber = 0;
            //

            // Input do user.
            string userinput;
            //

            /* Verificar se o user já definiu a quantidade de elementos
             * que quer colocar. */
            bool stopinputnumber = false;
            //

            // Nome do jogador.
            string inputname;
            //

            // Pontuação do jogador.
            int inputscore;
            //

            // Construtor do ficheiro.
            HighScoreManager highscoremanager =
                new HighScoreManager("highscores.txt");
            //

            // Definir a quantidade de elementos que o user quer colocar.
            while (stopinputnumber == false) {
                Console.WriteLine("Quantos scores quer colocar?");
                userinput = Console.ReadLine();
                if (int.TryParse(userinput, out inputnumber)) {
                    Console.WriteLine("Pode começar a colocar os scores.");
                    stopinputnumber = true;
                } else {
                    Console.WriteLine("Input incorrecto, tente de novo.");
                }
            }
            //

            // Definir os nomes dos jogadores e suas respetivas pontuações.
            for (int i = 0; i < inputnumber; i++) {
                Console.WriteLine("Escreva o nome");
                userinput = Console.ReadLine();
                inputname = userinput;
                Console.WriteLine("Escreva o score");
                userinput = Console.ReadLine();
                inputscore = Convert.ToInt32(userinput);
                highscoremanager.AddScore(inputname, inputscore);
            }
            //

            // Método para guardar os elementos da lista no ficheiro.
            highscoremanager.Save();
            //
        }
    }
}
