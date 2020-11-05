using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace _01_41
{
    class HighScoreManager
    {
        /// <summary>
        /// Lista do score (nomes e pontuações).
        /// </summary>
        private List<Tuple<string, float>> ScoreList =
            new List<Tuple<string, float>>();
        //

        /// <summary>
        /// Construtor do ficheiro.
        /// </summary>
        /// <param name="name"> Nome do ficheiro. </param>
        public HighScoreManager(string name) {
            FileCheck(name);
        }
        //

        /// <summary>
        /// Verificar a existência do ficheiro.
        /// </summary>
        /// <param name="file"> Nome do ficheiro. </param>
        private void FileCheck(string file) {
            if (File.Exists(file)) {
                Console.WriteLine("Ler ficheiro");
                Read(file);
            } 
            else if (!File.Exists(file)) {
                Console.WriteLine("Ficheiro não existe.");
            } 
            else if (Path.GetExtension(file) != ".txt") {
                throw new InvalidOperationException();
            }
        }
        //

        /// <summary>
        /// Método para ler o ficheiro e separar os dados.
        /// </summary>
        /// <param name="filename"> Nome do ficheiro. </param>
        private void Read(string filename) {
            string s;
            string[] lines;
            StreamReader streamreader = new StreamReader(filename);
            while((s = streamreader.ReadLine()) != null) {
                // Separar os dados por vírgula.
                lines = (s.Split(','));
                //
                // Colocar na lista os dados obtidos.
                AddScore(lines[0], float.Parse(lines[1]));
                //
                
            }
            streamreader.Close();
        }
        //

        /// <summary>
        /// Método para adicionar os dados à lista.
        /// </summary>
        /// <param name="name"> Nome do jogador. </param>
        /// <param name="score"> Pontuação do jogador. </param>
        public void AddScore(string name, float score) {
            ScoreList.Add(new Tuple<string, float>(name, score));
        }
        //

        /// <summary>
        /// Método para guardar os elementos da lista no ficheiro.
        /// </summary>
        public void Save() {
            StreamWriter streamwriter = new StreamWriter("highscores.txt");
            GetScores();
            foreach(Tuple<string, float> item in ScoreList) {
                streamwriter.WriteLine($"{item.Item1}, {item.Item2},");
            }
            streamwriter.Close();
        }
        //

        /// <summary>
        /// Método para ordenar por ordem decrescente a lista.
        /// </summary>
        private void GetScores() {
            // Ordenar o score
            CompareScore comparescore = new CompareScore();
            ScoreList.Sort(comparescore);
            //

            /* Caso a lista tenha mais de 10 elementos, remover os elementos 
            * com pontuação mais baixa até ficar nos 10 elementos.
            * Como a lista está ordenada por ordem decrescente,
            * removo o elemento que está no fundo (que é o mais baixo).*/
            while (ScoreList.Count > 10) {
                ScoreList.RemoveAt(ScoreList.Count - 1);
            }
            //
        }
        //
    }
}
