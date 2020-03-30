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

        public SingleEvent(string one, string two, int c2, int p2, int t2, int a2)
        {
            headline = one;
            info = two;
            c = c2;
            p = p2;
            t = t2;
            a = a2; 
        }
    }
}
