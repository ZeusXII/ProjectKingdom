using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Event // Event logics
    {
        protected string eventName;
        protected string eventInfo;
        public BaseEmpire newBaseEmpireState; // Placerholder for any empire object
        public bool isRunning;

        public Event(SingleEvent singleEvent, BaseEmpire empirE) //Needs the event data and base emprie object as input 
        {
            isRunning = true;
            eventName = singleEvent.headline;
            eventInfo = singleEvent.info;
            modifyState(singleEvent, empirE);
        }
        public void modifyState(SingleEvent singleEvent, BaseEmpire empirE)
        { // Method used for manipulating the state of the empire starting parameters, each choice impacts the parameters differently
            Console.Write(eventName + "\n" + eventInfo + "\n\n1. Act " + "2. Dont act" + " \nUser choice: ");
            int menuState;

            try
            {
                int userInput = int.Parse(Console.ReadLine());
                menuState = userInput;
        
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Only keys 1, 2 and 0 are accepted! Press ENTER to continue.");
                Console.ReadKey();
                menuState = 0;
            }

            switch (menuState)
            {

                case 0:
                    isRunning = false;
                    break;
                case 1:
                    empirE.church += singleEvent.c;
                    empirE.army += singleEvent.a;
                    empirE.treasure += singleEvent.t;
                    empirE.population += singleEvent.p;
                    break;
                case 2:
                    empirE.church += singleEvent.cN;
                    empirE.army += singleEvent.aN;
                    empirE.treasure += singleEvent.tN;
                    empirE.population += singleEvent.pN;

                    break;
                default:
                    
                    Console.WriteLine("Only keys 1 and 2 are accepted! Press ENTER to retry!");
                    Console.ReadKey();

                    break;
            }
            newBaseEmpireState = empirE;
        }

        public BaseEmpire Act() //Method used to return the new parameters after the player has choosen an action
        {
            return newBaseEmpireState;
        }

    }





}

