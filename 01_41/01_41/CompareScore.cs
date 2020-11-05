using System;
using System.Collections.Generic;
using System.Text;

namespace _01_41
{
    public class CompareScore : IComparer<Tuple<string, float>>
    {
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
    }
}
