using System;

namespace _01_14
{
    class Program
    {
        // Variável que acede ao GameMap;
        private static GameMap _gamemap;
        //
        // Array de mapas
        private static GameMap[] gamemaparray = new GameMap[5];
        //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            Map(new GameMap[5] {
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
        /// <param name="gamemap"></param>
        private static void Map(GameMap[] gamemap) {

            Console.WriteLine("Name              Filename      Sucess Rate    Top Score");
            Console.WriteLine("--------------------------------------------------------");
            
            for (int i = 0; i < gamemap.Length; i++) {
                string showname = string.Format("{0,0}", gamemap[i].Name);
                string showfilename = string.Format("{0,22}", gamemap[i].Filename);
                string showsuccessrate = string.Format("{0,12:p1}", gamemap[i].SuccessRate);
                string showtopscore = string.Format("{0,13:F3}", gamemap[i].TopScore);
                Console.WriteLine(showname + showfilename + showsuccessrate + showtopscore);
            }
        }
        //
    }
}
