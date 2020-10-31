using System;

namespace GameMap
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
            // Construir mapas e adicionar ao array
            /// <param name="name">Nome do mapa.</param>
            /// /// <param name="filename">Nome do ficheiro.</param>
            gamemaparray[0] = new GameMap
                (name: "Earth", filename: "earth.map");
            gamemaparray[1] = new GameMap
              (name: "Moon", filename: "moon.map");
            gamemaparray[2] = new GameMap
              (name: "Mars", filename: "mars.map");
            gamemaparray[3] = new GameMap
              (name: "Jupiter", filename: "Jupiter.map");
            gamemaparray[4] = new GameMap
              (name: "Uranus", filename: "uranus.map");
            //

            //Mostrar no ecrã os resultados
            Console.WriteLine("Name              Filename      Sucess Rate    Top Score");
            Console.WriteLine("--------------------------------------------------------");

            for (int i = 0; i < gamemaparray.Length; i++) {
                string showname = string.Format("{0,0}", gamemaparray[i].Name);
                string showfilename = string.Format("{0,22}", gamemaparray[i].Filename);
                string showsuccessrate = string.Format("{0,12:p1}", gamemaparray[i].SuccessRate);
                string showtopscore = string.Format("{0,13:F3}", gamemaparray[i].TopScore);
                Console.WriteLine(showname + showfilename + showsuccessrate + showtopscore);
            }
            //
        }
    }
}
