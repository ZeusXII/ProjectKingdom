using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Kingdom
    {
        protected int church;
        protected int peasants;
        protected int treasure;
        protected int army;

        protected int year; // "high score" håller reda på hur långe kungen sitter
        protected string kingName;

        public List<Tuple<string, string, int, int, int, int>> Events = new List<Tuple<string, string, int, int, int, int>>(); // Contains which type of events that can be created look at C# tuple types 
        

    }
}
