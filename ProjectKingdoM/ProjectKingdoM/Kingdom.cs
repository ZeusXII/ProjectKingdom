using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Kingdom : BaseEmpire
    {
        protected string kingName; //Name of the player/king

        
        public Kingdom() // Constructor, sets starting value of kingdom parameters
        {
            church = 80;
            population = 40;
            treasure = 30;
            army = 60;
        }
       
    }
}
