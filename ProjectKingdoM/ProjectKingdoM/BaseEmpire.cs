using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class BaseEmpire
    {
        //Four parametrs that will determin the state in the kingdom, values will change depending on actions taken by the player

        public int church; // Public bcs blablBL....
        public int population;
        public int treasure;
        public int army;

        public List<SingleEvent> Events = new List<SingleEvent>(); // Contains information about possible events 

        public void PresentParameters()
        {
            Console.WriteLine("###############\nChurch: " + church + "\nPopulation: " + population + "\nTreasure: " + treasure + "\nArmy: " + army + "\n###############");
        }
    }

}
