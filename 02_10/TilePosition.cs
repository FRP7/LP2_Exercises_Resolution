using System;

namespace _02_10
{
    public struct TilePosition
    {
        public static int XMax { get; internal set; }
        public static int YMax { get; internal set; }
        public int X { get; }
        public int Y { get; }

        public TilePosition(int x, int y) {
            XMax = 5;
            YMax = 5;
            X = x;
            Y = y;

            bool isX = true;
            bool isY = true;

            if(X >= 0 && X <= XMax) {
                isX = true;
            }
            else {
                isX = false;
            }

            if (Y >= 0 && Y <= YMax) {
                isY = true;
            }
            else {
                isY = false;
            }

            if (isX == false || isY == false) {
                throw new InvalidTilePositionException(isX, isY);
            } 
        }
    }
}
