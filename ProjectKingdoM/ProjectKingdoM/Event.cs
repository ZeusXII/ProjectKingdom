using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Event
    {
        //Might be uneccesary anävnds fö att skriva ut eventext i cwd
        protected string eventName;
        protected string eventInfo;
        public BaseEmpire newBaseEmpireState;
        public bool isRunning;

        //Constructor for 
        public Event(SingleEvent singleEvent, BaseEmpire empirE)
        {
            isRunning = true;
            eventName = singleEvent.headline;
            eventInfo = singleEvent.info;
            modifyState(singleEvent, empirE);


        }
        public void modifyState(SingleEvent singleEvent, BaseEmpire empirE)
        { // Method used for maniplating the state of the empire starting parameters, each choice imapcts the parameters differently
            Console.Write(eventName + "\n" + eventInfo + "\n\n0. Die (exits to main menu) 1. Act " + "2. Dont act" + " \nUser choice: ");
            int menu; //dummy var
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                menu = userInput;
            }
            catch (FormatException)
            {
                Console.WriteLine("Only keys 1 2 3 and 0 are accepted!");
                Console.ReadKey();
                menu = 0;
            }


            switch (menu)
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

