using System;
using System.Collections.Generic;
using System.Text;

namespace _01_14
{
    public struct GameMap
    {
        /// <summary>
        /// Variável da score mais alta.
        /// </summary>
        private float topScore;
        //

        /// <summary>
        /// Variável do número de jogos jogados.
        /// </summary>
        private int gamesPlayed;
        //

        /// <summary>
        /// Variável do número de jogos ganhos.
        /// </summary>
        private int gamesWon;
        //

        /// <summary>
        /// Variável de leitura (excepto no construtor) do nome do mapa.
        /// </summary>
        public string Name { get; }
        //

        /// <summary>
        /// Variável de leitura (excepto no construtor) de nome de ficheiro.
        /// </summary>
        public string Filename { get; }
        //

        /// <summary>
        /// Variável de leitura da percentagem de sucesso.
        /// </summary>
        public float SuccessRate {
            get {
                if (gamesPlayed == 0)
                    return 0f;
                else
                    return gamesWon / (float)gamesPlayed;
            }
        }
        //

        /// <summary>
        /// Variável de leitura do score mais alto.
        /// </summary>
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

        /// <summary>
        /// Construtor que cria objecto e define os valores das variáveis.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filename"></param>
        public GameMap(string name, string filename) {
            Name = name;
            Filename = filename;
            gamesPlayed = 0;
            gamesWon = 0;
            topScore = 0;
        }
        //

        /// <summary>
        /// Método que verifica se ganhou o jogo
        /// </summary>
        /// <param name="won"></param>
        public void GamePlayed(bool won) {
            gamesPlayed++;
            if (won) {
                gamesWon++;
            }
        }
        //
    }
}
