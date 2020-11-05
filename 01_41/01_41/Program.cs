using System;

namespace _01_41
{
    class Program
    {
        private static HighScoreManager highscoremanager;
        static void Main(string[] args) {
            highscoremanager = new HighScoreManager("highscores.txt");

            highscoremanager.AddScore("Francisco", 1);
            highscoremanager.AddScore("Joao", 2);
            highscoremanager.AddScore("Henrique", 3);
            highscoremanager.AddScore("Pedro", 4);
            highscoremanager.AddScore("Luis", 5);
            highscoremanager.Save();
        }
    }
}
