using System;

namespace _01_14
{
    class Program
    {
        /// <summary>
        /// Método para adicionar mapas e experimentar a solução.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args) {
            Rating(new GameMap[5] {
            new GameMap ("Earth", "earth.map"),
                new GameMap ("Moon", "moon.map"),
                new GameMap ("Mars", "mars.map"),
                new GameMap ("Jupiter", "jupiter.map"),
                new GameMap ("Uranus", "uranus.map") }
            );
        }

        /// <summary>
        /// Construir mapas e mostrar no ecrã.
        /// </summary>
        /// <param name="gamemap"> Array onde vão ser guardados os mapas para
        /// expor os dados</param>
        public static void Rating(GameMap[] gameMap) {

            Console.WriteLine("Name              Filename      Sucess Rate " +
                "   Top Score");
            Console.WriteLine("-------------------------------------------" +
                "-------------");

            for (int i = 0; i < gameMap.Length; i++) {
                string showName = string.Format("{0,-18}", gameMap[i].Name);
                string showFileName = string.Format("{0,-16}", 
                    gameMap[i].Filename);
                string showSuccessRate = string.Format("{0,-15:p1}", 
                    gameMap[i].SuccessRate);
                string showTopScore = string.Format("{0,0:F3}", 
                    gameMap[i].TopScore);
                Console.WriteLine(showName + showFileName + showSuccessRate + 
                    showTopScore);
            }
        }
    }
}
