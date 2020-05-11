using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class SingleEvent //Custom designed generic class similar to a tuple. Created to clean up the program from long tuple declartions. ALso track of information of one single event. Class is
    {      
        //Act variables 
        public string headline; 
        public string info;
        public int churchActVariable;
        public int populationActVariable;
        public int treasureActVariable;
        public int armyActVariable;
        //Don't act variables
        public int churchDontActVariable;
        public int populationDontActVariable;
        public int treasureDontActVariable;
        public int armyDontActVariable;
        public SingleEvent(string headlineString, string infoString, int cA, int pA, int tA, int aA, int cDA, int pDA, int tDA, int aDA)// Tuple like constructor xA = "xACT", xDA = "xDon'tAct where "x" is the beggining letter of one of the paramters, ex c for church
        {
            //"Act variables"
            headline = headlineString;
            info = infoString;
            churchActVariable = cA;
            populationActVariable = pA;
            treasureActVariable = tA;
            armyActVariable = aA;

            //"Don't act variables, used for changeing the parameter values in eventdata
            churchDontActVariable = cDA;
            populationDontActVariable = pDA;
            treasureDontActVariable = tDA;
            armyDontActVariable = aDA;
        }
    }
}
