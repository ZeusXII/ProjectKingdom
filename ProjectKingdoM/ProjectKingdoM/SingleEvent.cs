using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class SingleEvent
    {
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
