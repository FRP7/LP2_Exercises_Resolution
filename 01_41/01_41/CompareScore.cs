using System;
using System.Collections.Generic;
using System.Text;

namespace _01_41
{
    public class CompareScore : IComparer<Tuple<string, float>>
    {
        /// <summary>
        /// Método para comparar os scores
        /// </summary>
        /// <param name="a"> Tuple para comparar. </param>
        /// <param name="b"> Tuple para comparar. </param>
        /// <returns></returns>
        public int Compare(Tuple<string, float> a, Tuple<string, float> b) {
            if(a.Item2 > b.Item2) {
                return -1;
            }
            if (a.Item2 < b.Item2) {
                return 1;
            }
            else {
                return 0;
            }
        }
        //
    }
}
