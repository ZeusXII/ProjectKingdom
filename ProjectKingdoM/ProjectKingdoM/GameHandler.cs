using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class GameHandler // Class containing much of the logic that was present in main before. 
    {
        EventData eventD; 
        BaseEmpire bEmpire;
        public GameHandler(EventData e, BaseEmpire b) //Constryctor used to create necesary objects to be able for GameHandler to be created as a new object in main.
        {
            eventD = e;
            bEmpire = b;
        }
        public void MainLoop()
        {
            List<SingleEvent> incomingEventData = eventD.ReturnEvents(); //Imports data from EventData to be used by Event.cs to then be able to return the new empire state.
            bool introState = true;
            while (true)
            {
                if (introState)
                {
                    try
                    {
                        bEmpire = gameIntro(bEmpire); //Start a new empire with the gameIntro method 
                        introState = false;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Only keys 1 and 2 are accepted! Press ENTER to retry!");
                        Console.ReadKey();
                        continue;
                    }
                }

                Console.Clear();
                Console.WriteLine("Current status");
                bEmpire.PresentParameters(); 
                Console.WriteLine("===============Event===============");
                SingleEvent testRandom = RandomEventType(eventD.ReturnEvents()); //Takes one random event to be presented and randomly generated from the random generator.
                Event E = new Event(testRandom, bEmpire);
                bEmpire = E.Act();
                if (bEmpire.church <= 0 || bEmpire.population <= 0 || bEmpire.treasure <= 0 || bEmpire.army <= 0) // Logic responsible for ending the empire if any of the empire values drop below zero. Kicks the player back to the beginning of the program.
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Watch out your kingdom is in RUINS!!!!!!!!!!!!!! Press ENTER to restart");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    introState = true;
                    continue;
                }
                if (!E.isRunning)// Part of error correcting user input. Not working as intended, therefore it's not currently used
                {
                    /*
                    Console.Clear();
                    Console.WriteLine("If you want to quit, press q");
                    string userInput2;
                    userInput2 = Console.ReadLine();
                    if (userInput2 == "q")
                    {
                        break;
                    }
                    */
                }
                Console.WriteLine("==============================");
                Console.WriteLine("New status");
                bEmpire.PresentParameters();
                Console.Write("Press enter to continue");
                Console.ReadKey();
            }
        }
        public SingleEvent RandomEventType(List<SingleEvent> incomingList)
        {   //Generates a random order of possible pre-defined events 
            Random generator = new Random(); //Random generator used to present events in random order
            int eventTypeIndex = generator.Next(0, incomingList.Count);
            return incomingList[eventTypeIndex];
        }
        public BaseEmpire gameIntro(BaseEmpire bEmpire) //Contains the basic tutorial presented in the beginning of the program
        {
            Console.Clear();
            Console.WriteLine("Welcome to project kingdom!\n###Instructions###\nIn project kingdom you will play as a leader of an empire. You will be faced with different events, you can either choose to act on the event or refuse to act. Keep in mind that your action will have consequences on your empire's status. Press ENTER to continue the tutorial");
            Console.ReadKey();
            Console.WriteLine("Your empire has 4 parameters, church, population, treasury and army. Your actions will either increase or decrease the value of each paramter, if one value goes below 0 your empire will fail. Good luck! \n###End of instructions###\n Press ENTER to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Choose empire type\n0.Exit program\n1. Kingdom \n2. Republic");
            int userInput = int.Parse(Console.ReadLine());
            int menu = userInput;

            switch (menu) //Let's the user choose either a kingdom start or republic start, only change is in starting values
            {
                case 0:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                case 1:

                    bEmpire = new Kingdom();
                    break;
                case 2:

                    bEmpire = new Republic();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ooga booga, nu blev det fel. Programmet stängs ned.");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                    break;
            }
            return bEmpire; //return chosoen baseEmpire type
        }
    }
}
