using System;

namespace _01_14
{
    public struct GameMap
    {
        /// <summary>
        /// Score mais alta.
        /// </summary>
        private float topScore;

        /// <summary>
        /// Número de jogos jogados.
        /// </summary>
        private int gamesPlayed;

        /// <summary>
        /// Número de jogos ganhos.
        /// </summary>
        private int gamesWon;

        /// <summary>
        /// Nome do mapa.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Nome de ficheiro.
        /// </summary>
        public string Filename { get; }

        /// <summary>
        /// Percentagem de sucesso.
        /// </summary>
        public float SucessRate {
            get {
                if (gamesPlayed == 0)
                    return 0f;
                else
                    return gamesWon / (float)gamesPlayed;
            }
        }

        /// <summary>
        /// Score mais alta.
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

        /// <summary>
        /// Construtor que cria objecto e define os valores das respetivas
        /// variáveis.
        /// </summary>
        /// <param name="name"> Nome do mapa. </param>
        /// <param name="filename"> Nome do ficheiro </param>
        public GameMap(string name, string fileName) {
            Name = name;
            Filename = fileName;
            gamesPlayed = 0;
            gamesWon = 0;
            topScore = 0;
        }

        /// <summary>
        /// Método que incrementa gamesPlayed e Gameswon (este último sendo 
        /// caso um jogo seja ganho).
        /// </summary>
        /// <param name="won"> Bool que indica se ganhou um jogo. </param>
        public void GamePlayed(bool won) {
            gamesPlayed++;
            if (won) {
                gamesWon++;
            }
        }
    }
}
