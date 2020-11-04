using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

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
            string[] lines = File.ReadAllLines("highscores.txt");
            string[] col = new string[10];
            // Meter o conteúdo do ficheiro na coleção
            foreach(string line in lines) {
                col = (line.Split(','));
                AddScore(col[0], float.Parse(col[1]));
                col[0] = default;
                col[1] = default;
            }
            //AddScore(col[0], float.Parse(col[1]));
        }

        public void AddScore(string name, float score) {
                scorelist.Add(new Tuple<string, float>(name, score));
                //Console.WriteLine("Count: " + scorelist.Count);
            GetScores();
            while(scorelist.Count > 10) {
                // remover o que está no fundo da lista (tenho que ordenar primeiro)
                scorelist.RemoveAt(scorelist.Count - 1);
            }

            // Só para eu ver o que se passa, delete later
            foreach (var tuple in scorelist) {
                Console.WriteLine("{0} - {1}", tuple.Item1, tuple.Item2.ToString());
            }
            //
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
