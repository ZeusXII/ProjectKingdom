using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class BaseEmpire // Keeping track of empire related data
    {
        //Four parametrs that will determin the state in the kingdom, values will change by actions taken 
        public int church; 
        public int population;
        public int treasure;
        public int army;
      
        public void PresentParameters() // A simple method presenting the values of the empire parameters when the game is running
        {
            Console.WriteLine("###############\nChurch: " + church + "\nPopulation: " + population + "\nTreasure: " + treasure + "\nArmy: " + army + "\n###############");
        }
    }

}
