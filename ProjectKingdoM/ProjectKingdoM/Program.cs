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
            List<Tuple<string, string, int, int, int, int>> incomingEventData = e.ReturnEvents(); //Imports data from EventData
            BaseEmpire B = new BaseEmpire(); //Base class        
            Console.WriteLine("Choose empire type\n1. Kingdom \n2. Republic");
            int userInput = int.Parse(Console.ReadLine());
            int menu = userInput;
            switch (menu)
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
                Console.WriteLine("HejHej" + RandomEventType(incomingEventData));
                B.PresentParameters();
                Console.ReadKey();
            }

            Console.ReadKey();
        }

        static Random generator = new Random();

        static Tuple<string, string, int, int, int, int> RandomEventType(List<Tuple<string, string, int, int, int, int>> incomingList)
        {
            int eventTypeIndex = generator.Next(0, incomingList.Count);
            return incomingList[eventTypeIndex]; 
        }

    }
}
