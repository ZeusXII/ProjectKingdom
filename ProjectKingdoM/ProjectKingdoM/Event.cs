using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class Event : Kingdom
    {
        protected string eventName;
        protected string eventInfo;

        //Ints used to track value changes throughout the game
        protected int modifyChurch;
        protected int modifyPopulation;
        protected int modifyArmy;
        protected int modifyTreasure;

        public Event() // Konstruktor
        {

        }
        public void Act()
        {
            int playerChoice;
            bool success = false;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out playerChoice);
            }
            int menu = playerChoice;
            switch (menu)
            {
                case 1:
                    Console.WriteLine("-Church");
                    break;
                case 2:
                    Console.WriteLine("+Church");
                    break;
                default:
                    Console.WriteLine("Ooga booga");
                 break;
            }

        }
        public void buildWarehouse()
        {

        }


    }
}
