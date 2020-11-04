using System;
using System.Collections.Generic;
using System.Text;

namespace _01_14
{
    public struct GameMap
    {
        // Variável da score mais alta.
        private float topScore;
        //
        // Variável do número de jogos jogados.
        private int gamesPlayed;
        //
        // Variável do número de jogos ganhos.
        private int gamesWon;
        //

        // Variável de leitura (excepto no construtor) do nome do mapa.
        public string Name { get; }
        //
        // Variável de leitura (excepto no construtor) de nome de ficheiro.
        public string Filename { get; }
        //

        // Variável de leitura da percentagem de sucesso.
        public float SuccessRate {
            get {
                if (gamesPlayed == 0)
                    return 0f;
                else
                    return gamesWon / (float)gamesPlayed;
            }
        }
        //

        // Variável de leitura do score mais alto
        public float TopScore {
            get {
                return topScore;
            }
            set {
                if (value > topScore) {
                    topScore = value;
                }
            }
        }
        //

        // Construtor que cria objecto e define os valores das variáveis.
        /// <param name="name">Nome do mapa.</param>
        /// /// <param name="filename">Nome do ficheiro.</param>
        public GameMap(string name, string filename) {
            Name = name;
            Filename = filename;
            gamesPlayed = 0;
            gamesWon = 0;
            topScore = 0;
        }
        //

        // Método que verifica se ganhou o jogo
        /// <param name="won">Bool que verifica se ganhou o jogo</param>
        public void GamePlayed(bool won) {
            gamesPlayed++;
            if (won) {
                gamesWon++;
            }
        }
        //
    }
}
