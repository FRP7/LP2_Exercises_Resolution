using System;
using System.Collections.Generic;
using System.IO;

namespace _01_41
{
    class HighScoreManager
    {
        public List<Tuple<string, float>> scorelist =
            new List<Tuple<string, float>>();

        public HighScoreManager(string name) {
            if (File.Exists(name)) {
                Console.WriteLine("Ler ficheiro");
                Read();
            }
            else if(!File.Exists(name)) {
                Console.WriteLine("Ficheiro não existe.");
                // Inicializar coleção sem elementos
            } 
            else if (Path.GetExtension(name) != ".txt") {
                throw new InvalidOperationException();
            }
        }

        private void Read() {
            StreamReader streamreader = new StreamReader("highscores.txt");
            // Meter o conteúdo do ficheiro na coleção
            streamreader.Close();
        }

        public void AddScore(string name, float score) {
                scorelist.Add(new Tuple<string, float>(name, score));
                Console.WriteLine("Count: " + scorelist.Count);
            GetScores();
            while(scorelist.Count > 10) {
                // remover o que está no fundo da lista (tenho que ordenar primeiro)
                scorelist.RemoveAt(scorelist.Count - 1);
            }
        }

        private void Save() {
            // guardar os scores no ficheiro
        }

        public override string ToString() {
            // devolver uma string contendo uma tabela formatada com nomes 
            //e scores do mais alto ao mais baixo
            return base.ToString();
        }

        private void GetScores() {
            CompareScore compareclass = new CompareScore();
            scorelist.Sort(compareclass);
            // método iterável que retorna de forma ordenada (mais alto até mais baixo)
            // todos tuplos guardados na coleção
        }
    }
}
