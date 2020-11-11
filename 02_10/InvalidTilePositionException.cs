using System;
using System.Collections.Generic;
using System.Text;

namespace _02_10
{
    public class InvalidTilePositionException : Exception
    {
        private string finalmessage;
        public override string Message => finalmessage; 

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
    }
}
