using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class SingleEvent
    {
        //Class used for cleaning the program code up a bit by calling on it as a constructor instead of "Tuple<string, string, int, int, int, int>"
        public string headline;
        public string info;
        public int c;
        public int p;
        public int t;
        public int a;
        //Don't act ...
        public int cN;
        public int pN;
        public int tN;
        public int aN;
        public SingleEvent(string one, string two, int c2, int p2, int t2, int a2, int c2D, int p2D, int t2D, int a2D)
        {
            headline = one;
            info = two;
            c = c2;
            p = p2;
            t = t2;
            a = a2;

            //"Don't act" values
            cN = c2D;
            pN = p2D;
            tN = t2D;
            aN = a2D;
        }
    }
}
