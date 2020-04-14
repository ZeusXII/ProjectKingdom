using System;
using System.Collections.Generic;
namespace ProjectKingdoM
{
    class Program
    {
        static void Main(string[] args)
        {
            EventData e = new EventData(); //
            List<SingleEvent> incomingEventData = e.ReturnEvents(); //Imports data from EventData
            BaseEmpire B = new BaseEmpire(); //Base empire type class  
            
            bool introState = true;
            while (true)
            {
                if (introState)
                {
                    try
                    {
                        B = gameIntro(B);
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
                B.PresentParameters();
                Console.WriteLine("===============Event===============");
                SingleEvent testRandom = RandomEventType(e.ReturnEvents()); //One random event    
                Event E = new Event(testRandom, B);
                B = E.Act();
                if (B.church <= 0 || B.population <= 0 || B.treasure <= 0 || B.army <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Watch out your kingdom is in RUINS!!!!!!!!!!!!!! Press ENTER to restart");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    introState = true;
                    continue;
                    
                }
                if(!E.isRunning)// Not working 
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
                B.PresentParameters();
                Console.Write("Press enter to continue");
                Console.ReadKey();
            }
            System.Environment.Exit(0);
        }

        static Random generator = new Random(); //Random generator used for the method below

        static SingleEvent RandomEventType(List<SingleEvent> incomingList)
        { //Generates a random order of possible pre-defined events 
            int eventTypeIndex = generator.Next(0, incomingList.Count);
            return incomingList[eventTypeIndex];
        }

        static BaseEmpire gameIntro(BaseEmpire B) //Contains 
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

                    B = new Kingdom();
                    break;
                case 2:

                    B = new Republic();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ooga booga, nu blev det fel. Programmet stängs ned.");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                    break;
            }
            return B;
        }

    }
}
