using System;

namespace _02_10
{
    public struct TilePosition
    {
        // Propriedade que define limite máximo do X.
        public static int XMax { get; internal set; }
        
        // Propriedade que define limite máximo do Y.
        public static int YMax { get; internal set; }
        
        // Propriedade de leitura que define o valor do X.
        public int X { get; }
        
        // Propriedade de leitura que define o valor do Y.
        public int Y { get; }

        /// <summary>
        /// Construtor de TilePosition.
        /// </summary>
        /// <param name="x"> Definir o valor de X. </param>
        /// <param name="y"> Definir o valor de Y. </param>
        public TilePosition(int x, int y, int xMax) {

            // Definir que os valores X e Y são iguais aos dos parâmetros.
            X = x;
            Y = y;

            /* Variáveis bool que verificam se os valores de X e Y 
             * respeitam os limites. */
            bool isX = true;
            bool isY = true;

            // Verificar se X respeita os limites.
            isX = X >= 0 && X <= XMax ? true : false;

            // Verificar se Y respeita os limites.
            isY = Y >= 0 && Y <= YMax ? true : false;

            // Verificar se pelo menos um dos bools é falso.
            if (isX == false || isY == false) {
                throw new InvalidTilePositionException(isX, isY);
            } 
        }
    }
}
