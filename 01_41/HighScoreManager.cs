using System;
using System.Collections.Generic;
using System.IO;


namespace ScoreManager
{
    class HighScoreManager
    {
        // Lista dos scores
        private List<Tuple<string, float>> scorelist =
            new List<Tuple<string, float>>(); 
        //
        // Nome do jogador
        private string getname { get; set; }
        //
        // Score do jogador
        private float getscore { get; set; }
        //
        // Caminho para o local do ficheiro
        private string path = "C:/Users/Francisco/Documents/GitHub/ScoreManager/score.txt";
        //

        // Construtor
        public HighScoreManager() {
            Console.WriteLine("Construir");
            // Verificar se existe o ficheiro
            if(File.Exists(path)) {
                // Ler o ficheiro
                Read();
                //
            } 
            else {
                Console.WriteLine("Não existe");
            }
            //
        }
        //

        // Método para ler o ficheiro
        private void Read() {
            Console.WriteLine("Ler ficheiro");
            // Array para expor o score
            string[] lines = System.IO.File.ReadAllLines(path);
            //
            // Mostrar no ecrã o score
            foreach(string line in lines) {
                Console.WriteLine(line);
            }
            //
        }
        //

        // Adicionar valores à lista do score
        public void AddScore(string name, float score) {
            getname = name;
            getscore = score;
            scorelist.Add(new Tuple<string, float>(name, score));
        }
        //

        // Guardar o score num ficheiro txt
        public void Save() {
            System.IO.File.WriteAllText(path,
                "Score:" + Environment.NewLine + ToString());
        }
        //

        // Converter o score para string
        public override string ToString() {
            string result = string.Join(Environment.NewLine, scorelist);
            return result;
        }
        //

        // Ordenar o score e remover os que estão a mais
        public void GetScores() {
            // Ordenar o score
            scorelist.Sort((getname, getscore) =>
            getscore.Item2.CompareTo(getname.Item2));
            //

            // Remover os que estão a mais
            while(scorelist.Count > 10) { 
                Console.WriteLine($"Remover {scorelist[scorelist.Count -1]}");
                scorelist.RemoveAt(scorelist.Count -1);
            }
            //

        }
        //
    }
}
