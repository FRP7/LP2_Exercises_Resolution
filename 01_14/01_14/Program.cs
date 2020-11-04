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

        static void Main(string[] args) {
                Map(new GameMap[5]);
        }

        private static void Map(GameMap[] gamemap) {
            // Construir mapas e adicionar ao array
            /// <param name="name">Nome do mapa.</param>
            /// /// <param name="filename">Nome do ficheiro.</param>
            gamemap[0] = new GameMap
                (name: "Earth", filename: "earth.map");
            gamemap[1] = new GameMap
              (name: "Moon", filename: "moon.map");
            gamemap[2] = new GameMap
              (name: "Mars", filename: "mars.map");
            gamemap[3] = new GameMap
              (name: "Jupiter", filename: "Jupiter.map");
            gamemap[4] = new GameMap
              (name: "Uranus", filename: "uranus.map");
            //

            //Mostrar no ecrã os resultados
            Console.WriteLine("Name              Filename      Sucess Rate    Top Score");
            Console.WriteLine("--------------------------------------------------------");

            for (int i = 0; i < gamemap.Length; i++) {
                string showname = string.Format("{0,0}", gamemap[i].Name);
                string showfilename = string.Format("{0,22}", gamemap[i].Filename);
                string showsuccessrate = string.Format("{0,12:p1}", gamemap[i].SuccessRate);
                string showtopscore = string.Format("{0,13:F3}", gamemap[i].TopScore);
                Console.WriteLine(showname + showfilename + showsuccessrate + showtopscore);
            }
            //
        }
    }
}
