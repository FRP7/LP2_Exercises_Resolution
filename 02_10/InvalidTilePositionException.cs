using System;
using System.Collections.Generic;
using System.Text;

namespace _02_10
{
    public class InvalidTilePositionException : Exception
    {
        // Variável string com o texto a mostrar na mensagem de erro.
        private string finalmessage;
        //
        // Fazer override da Mensagem mãe com a finalmessage.
        public override string Message => finalmessage;
        //

        /// <summary>
        /// Construtor de InvalidTilePositionException.
        /// </summary>
        /// <param name="x"> Valor de isX. </param>
        /// <param name="y"> Valor de isY. </param>
        public InvalidTilePositionException(bool x, bool y) {
            if(x == false) {
                finalmessage = "O X está fora do intervalo";
            }
            if (y == false) {
                finalmessage = "O Y está fora do intervalo";
            }
            if (x == false && y == false) {
                finalmessage = "O Y e o X estão fora do intervalo";
            }
        }
        //
    }
}
