using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Event 
    {
        //Might be uneccesary
        protected string eventName;
        protected string eventInfo;
        public BaseEmpire newBaseEmpireState;

        //Constructor for 
        public Event(SingleEvent singleEvent, BaseEmpire empirE)
        {
            eventName = singleEvent.headline;
            eventInfo = singleEvent.info;
            modifyState(singleEvent, empirE);

        }
        public void modifyState(SingleEvent singleEvent, BaseEmpire empirE)
        { // Method used for maniplating the state of the empire starting parameters, each choice imapcts the parameters differently
            Console.Write(eventName + "\n" + eventInfo + "\n\n1. Act " + "2. Dont act" + " \nUser choice: " );
            int userInput = int.Parse(Console.ReadLine());
            int menu = userInput;
            switch (menu)
            {
                case 1:
                    empirE.church += singleEvent.c;
                    empirE.army += singleEvent.a;

                    break;
                case 2:
                    empirE.treasure += singleEvent.t;
                    empirE.population += singleEvent.p;

                    break;
                default:
                    Console.WriteLine("Ooga booga");
                    break;
            }
            newBaseEmpireState = empirE;
        }
        public BaseEmpire Act() //Methodused to return the new parameters after the player has choosen an action
        {          
            return newBaseEmpireState;
        }

    }
    
    



}

