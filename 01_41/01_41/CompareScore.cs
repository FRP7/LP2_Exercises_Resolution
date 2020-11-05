using System;
using System.Collections.Generic;
using System.Text;

namespace _01_41
{
    class CompareScore : IComparer<Tuple<string, float>>
    {
        /// <summary>
        /// Método para comparar o score e ordenar por ordem decrescente.
        /// </summary>
        /// <param name="a"> Tuple para ser comparado. </param>
        /// <param name="b"> Tuple para ser comparado. </param>
        /// <returns></returns>
        public int Compare(Tuple<string, float> a, Tuple<string, float> b) {
            if(a.Item2 > b.Item2) {
                return -1;
            } 
            else if(a.Item2 > b.Item2) {
                return 1;
            }
            else {
                return 0;
            }
        }
        //
    }
}
