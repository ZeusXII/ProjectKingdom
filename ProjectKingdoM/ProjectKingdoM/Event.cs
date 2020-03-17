using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Event 
    {
        protected string eventName;
        protected string eventInfo;
        private Kingdom newKingdomState;

        //Ints used to track value changes throughout the game
        protected int modifyChurch;
        protected int modifyPopulation;
        protected int modifyArmy;
        protected int modifyTreasure;

        public Event(Tuple<string, string, int, int, int, int> singleEvent, Kingdom kingdomS)
        {
            eventName = singleEvent.Item1;
            eventInfo = singleEvent.Item2;
            modifyState(singleEvent, kingdomS);

        }
        public void modifyState(Tuple<string, string, int, int, int, int> singleEvent, Kingdom kingdomS)
        {
            Console.WriteLine(eventName + "\n" + eventInfo + "\n1. Agera " + "2. Agera inte" );
            int userInput = int.Parse(Console.ReadLine());
            int menu = userInput;
            switch (menu)
            {
                case 1:
                    kingdomS.church += singleEvent.Item3;
                    kingdomS.army += singleEvent.Item5;

                    break;
                case 2:
                    kingdomS.treasure += singleEvent.Item6;
                    kingdomS.population += singleEvent.Item4;

                    break;
                default:
                    Console.WriteLine("Ooga booga");
                    break;
            }
            newKingdomState = kingdomS;
        }
        public Kingdom Act()
        {
            /*
            int playerChoice;
            bool success = false;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out playerChoice);
            }
            */
           
            return newKingdomState;

        }

    }
    
    



}

