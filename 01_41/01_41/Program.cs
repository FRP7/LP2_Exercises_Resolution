using System;

namespace _01_41
{
    class Program
    {
        private static HighScoreManager highscoremanager;
        static void Main(string[] args) {
            highscoremanager = new HighScoreManager("highscores.txt");

            highscoremanager.AddScore("Gervásio", 6);
            highscoremanager.AddScore("Lucas", 7);
            highscoremanager.AddScore("Gustavo", 8);
            highscoremanager.Save();
        }
    }
}
