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
            catch (FormatException) // Part of error correcting if user types in an invalid letter/number
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
                case 1: //Applies predefined act values (which are located in EvenData.cs/ListOfEvents)
                    empirE.church += singleEvent.churchActVariable;
                    empirE.army += singleEvent.armyActVariable;
                    empirE.treasure += singleEvent.treasureActVariable;
                    empirE.population += singleEvent.populationActVariable;
                    break;
                case 2: //Applies predefined don't act values (which are located in EvenData.cs/ListOfEvent)
                    empirE.church += singleEvent.churchDontActVariable;
                    empirE.army += singleEvent.armyDontActVariable;
                    empirE.treasure += singleEvent.treasureDontActVariable;
                    empirE.population += singleEvent.populationDontActVariable;

                    break;
                default:
                    
                    Console.WriteLine("Only keys 1 and 2 are accepted! Press ENTER to retry!"); //Error correction of invalid user input
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

