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
            Rating(new GameMap[6] {
            new GameMap ("Earth", "earth.map"),
                new GameMap ("Moon", "moon.map"),
                new GameMap ("Mars", "mars.map"),
                new GameMap ("Jupiter", "jupiter.map"),
                new GameMap ("TestePlanet123", "testeplanet123.map"),
                new GameMap ("Uranus", "uranus.map") }
            );
        }

        /// <summary>
        /// Construir mapas e mostrar no ecrã.
        /// </summary>
        /// <param name="gamemap"> Array onde vão ser guardados os mapas para
        /// expor os dados</param>
        public static void Rating(GameMap[] gamemap) {

            Console.WriteLine("Name              Filename      Sucess Rate " +
                "   Top Score");
            Console.WriteLine("-------------------------------------------" +
                "-------------");

            for (int i = 0; i < gamemap.Length; i++) {
                string showName = gamemap[i].Name;
                string showFilename = "\t\t" + gamemap[i].Filename;
                string showSuccessrate = string.Format("\t{0:p1}",
                    gamemap[i].SuccessRate);
                string showTopscore = string.Format("\t{0,13:F3}",
                    gamemap[i].TopScore);
                Console.WriteLine(showName + showFilename + showSuccessrate
                    + showTopscore);
            }
        }

        //dados (delete later):
        /*
            * name: 1-5 px
            filenae: 19-27px
            sucess rate: 33-45px
            top score: 47-57px
         */
    }
}
