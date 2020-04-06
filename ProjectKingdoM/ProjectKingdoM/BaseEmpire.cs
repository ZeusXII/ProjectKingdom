using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class BaseEmpire // Keeping track of empire related data
    {
        //Four parametrs that will determin the state in the kingdom, values will change depending on actions taken by the player
        public int church; 
        public int population;
        public int treasure;
        public int army;
      
        public void PresentParameters()
        {
            Console.WriteLine("###############\nChurch: " + church + "\nPopulation: " + population + "\nTreasure: " + treasure + "\nArmy: " + army + "\n###############");
        }
    }

}
