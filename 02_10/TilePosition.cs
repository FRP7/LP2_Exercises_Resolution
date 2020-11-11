using System;

namespace _02_10
{
    public struct TilePosition
    {
        // Propriedade que define limite máximo do X.
        public static int XMax { get; internal set; }
        //
        // Propriedade que define limite máximo do Y.
        public static int YMax { get; internal set; }
        //
        // Propriedade de leitura que define o valor do X.
        public int X { get; }
        //
        // Propriedade de leitura que define o valor do Y.
        public int Y { get; }
        //

        /// <summary>
        /// Construtor de TilePosition.
        /// </summary>
        /// <param name="x"> Definir o valor de X. </param>
        /// <param name="y"> Definir o valor de Y. </param>
        public TilePosition(int x, int y) {
            // Definir os valores do XMax e YMax.
            XMax = 5;
            YMax = 5;
            //

            // Definir que os valores X e Y são iguais aos dos parâmetros.
            X = x;
            Y = y;
            //

            /* Variáveis bool que verificam se os valores de X e Y 
             * respeitam os limites. */
            bool isX = true;
            bool isY = true;
            //

            // Verificar se X respeita os limites.
            if(X >= 0 && X <= XMax) {
                isX = true;
            }
            else {
                isX = false;
            }
            //

            // Verificar se Y respeita os limites.
            if (Y >= 0 && Y <= YMax) {
                isY = true;
            }
            else {
                isY = false;
            }
            //

            // Verificar se pelo menos um dos bools é falso.
            if (isX == false || isY == false) {
                throw new InvalidTilePositionException(isX, isY);
            } 
            //
        }
        //
    }
}
