using System;

namespace _01_41
{
    class Program
    {
        private static HighScoreManager highscoremanager;
        static void Main(string[] args) {
            int inputnumber = 0;
            string userinput;
            bool stopinputnumber = false;
            string inputname;
            int inputscore;
            highscoremanager = new HighScoreManager("highscores.txt");
            //highscoremanager.AddScore();
            /*while(true) {
                highscoremanager.AddScore(Console.ReadLine(), 
                    float.Parse(Console.ReadLine()));
            }*/
            while(stopinputnumber == false) {
                Console.WriteLine("Quantos scores quer colocar?");
                userinput = Console.ReadLine();
                if(int.TryParse(userinput, out inputnumber)) {
                    Console.WriteLine("Pode começar a colocar os scores.");
                    stopinputnumber = true;
                } else {
                    Console.WriteLine("Input incorrecto, tente de novo.");
                }
            }

            for (int i = 0; i < inputnumber; i++) {
                Console.WriteLine("Escreva o nome");
                userinput = Console.ReadLine();
                inputname = userinput;
                Console.WriteLine("Escreva o score");
                userinput = Console.ReadLine();
                inputscore = Convert.ToInt32(userinput);
                highscoremanager.AddScore(inputname, inputscore);
            }

        }
    }
}
