﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectKingdoM
{
    class Program
    {
        static void Main(string[] args)
        {
            EventData e = new EventData();
            List<SingleEvent> incomingEventData = e.ReturnEvents(); //Imports data from EventData
            BaseEmpire B = new BaseEmpire(); //Base empire type class        
            Console.WriteLine("Choose empire type\n0.Exit program\n1. Kingdom \n2. Republic");
            int userInput = int.Parse(Console.ReadLine());
            int menu = userInput;
            switch (menu) //Let's the user choose either a kingdom start or republic start, only chnge in starting values
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

            while (true)
            {

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
                    Console.WriteLine("WatCH Out YoUR KinGdoM IS iN RuInS!!!!!!!!!!!!!!");
                }
                if (!E.isRunning)
                {
                    Console.Clear();
                    Console.WriteLine("If you want to quit, press q");
                    string userInput2;
                    userInput2 = Console.ReadLine();
                    if (userInput2 == "q")
                    {
                        break;
                    }
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

    }
}
