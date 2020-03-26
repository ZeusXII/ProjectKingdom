using System;
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
            Console.WriteLine("Choose empire type\n1. Kingdom \n2. Republic");
            int userInput = int.Parse(Console.ReadLine());
            int menu = userInput;
            switch (menu) //Let's the user choose either a kingdom start or republic start, only chnge in starting values
            {
                case 1:

                    B = new Kingdom();
                    break;
                case 2:

                    B = new Republic();
                    break;
                default:
                    Console.WriteLine("Ooga booga");
                    break;
            }

            while (true)
            {
                SingleEvent testRandom = RandomEventType(e.ReturnEvents()); //One random event
                B = new Event(testRandom, B).Act();
                B.PresentParameters();
                Console.WriteLine("Press to continue");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        static Random generator = new Random(); //Random generator used for the method below

        static SingleEvent RandomEventType(List<SingleEvent> incomingList)
        { //Generates a random order of possible pre-defined events 
            int eventTypeIndex = generator.Next(0, incomingList.Count);
            return incomingList[eventTypeIndex];
        }

    }
}
