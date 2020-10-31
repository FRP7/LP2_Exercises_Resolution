using System;

namespace ScoreManager
{
    class Program
    {
        // Aceder à classe HighScoreManager
        private static HighScoreManager _highscoremanager;
        //

        private static void Main(string[] args) {
            // Chamar construtor
            _highscoremanager = new HighScoreManager(); 
            //
            // Input do user
            string userinput;
            //
            // Nome
            string inputname;
            //
            // Score
            float inputscore;
            //
            // Número de resultados que o user vai colocar
            int index = 0;
            //
            Console.WriteLine("Quantos resultados quer meter?: ");
            // Input do user
            userinput = Console.ReadLine();
            //
            // Converter o input para int
            index = Convert.ToInt32(userinput);
            //

            for (int i = 0; i < index; i++) {
                Console.WriteLine("Coloque o nome: ");
                // Input do user
                userinput = Console.ReadLine();
                //
                // Colocar o input na variável do nome
                inputname = userinput;
                //
                Console.WriteLine("Coloque o score: ");
                // Input do user
                userinput = Console.ReadLine();
                //
                // Converter o input para float e colocar na variável do score
                inputscore = float.Parse(userinput);
                //
                // Adicionar o score
                _highscoremanager.AddScore(inputname, inputscore);
                //
            }

            // Chamar o método GetScores para ordenar os scores
            _highscoremanager.GetScores();
            //
            Console.WriteLine("Score: ");
            // Mostrar no ecrã os scores
            Console.WriteLine(_highscoremanager.ToString());
            //
            // Guardar os scores num ficheiro
            _highscoremanager.Save();
            //
        }
    }
}
