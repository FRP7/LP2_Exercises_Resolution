using System;

namespace _02_10
{
    class Program
    {
        static void Main(string[] args) {
            // Experimentar os valores.
            try {
                TilePosition tileposition1 = new TilePosition(3, 3, 5);
            }
            catch(InvalidTilePositionException msg) {
                Console.WriteLine(msg.Message);
            }

            try {
                TilePosition tileposition1 = new TilePosition(6, 3, 5);
            }
            catch (InvalidTilePositionException msg) {
                Console.WriteLine(msg.Message);
            }

            try {
                TilePosition tileposition1 = new TilePosition(3, 6, 5);
            }
            catch (InvalidTilePositionException msg) {
                Console.WriteLine(msg.Message);
            }

            try {
                TilePosition tileposition1 = new TilePosition(6, 6, 5);
            }
            catch (InvalidTilePositionException msg) {
                Console.WriteLine(msg.Message);
            }
        }
    }
}
