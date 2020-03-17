using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Kingdom
    {
        //Four parametrs that will determin the state in the kingdom, values will change depending on actions taken by the player
        public int church;
        public int population;
        public int treasure;
        public int army;

        protected int year; // Keeps track of how many years passes, could be seen as a "high score after the game ends". 
        protected string kingName;

        public List<Tuple<string, string, int, int, int, int>> Events = new List<Tuple<string, string, int, int, int, int>>(); // Contains information about possible events 
        
        public Kingdom() // Constructor, sets starting value of kingdom parameters
        {
            church = 100;
            population = 100;
            treasure = 100;
            army = 100;
        }
        public void PresentParameters()
        {
            Console.WriteLine("###############\nChurch: " + church + "\nPopulation: " + population + "\nTreasure: " + treasure + "\nArmy: " + army + "\n###############");
        }
    }
}
