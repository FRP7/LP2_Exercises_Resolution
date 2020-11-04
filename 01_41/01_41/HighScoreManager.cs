using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _01_41
{
    class HighScoreManager
    {
        private List<Tuple<string, float>> scorelist =
            new List<Tuple<string, float>>(10);

        public HighScoreManager(string name) {
            if (File.Exists(name)) {
                Console.WriteLine("Ler ficheiro");
                Open();
            }
            else if(!File.Exists(name)) {
                Console.WriteLine("Não existe, a coleção vai ser inicializada sem elementos");
            } 
            else if (Path.GetExtension(name) != ".txt") {
                throw new InvalidOperationException();
            }
        }

        private void Open() {
            StreamReader streamreader = new StreamReader("highscores.txt");
            string teste;
            while((teste = streamreader.ReadLine()) != null) {
                Console.WriteLine(teste);
            }
            streamreader.Close();
        }

        private void AddScore(string name, float score) {

        }

        public override string ToString() {
            return base.ToString();
        }

        private void GetScores() {

        }
    }
}
