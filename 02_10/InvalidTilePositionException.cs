using System;

namespace _02_10
{
    public class InvalidTilePositionException : Exception
    {

        // Fazer override da Mensagem.
        public override string Message { get; }

        /// <summary>
        /// Construtor de InvalidTilePositionException.
        /// </summary>
        /// <param name="x"> Valor de isX. </param>
        /// <param name="y"> Valor de isY. </param>
        public InvalidTilePositionException(bool x, bool y) {
            if(x != true) {
                Message = "O X está fora do intervalo";
            }
            if(y != true) {
                Message = "O Y está fora do intervalo";
            } 
            if(x != true && y != true) {
                Message = "O Y e o X estão fora do intervalo";
            }
        }
    }
}
