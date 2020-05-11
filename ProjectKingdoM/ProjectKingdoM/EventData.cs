
using System.Collections.Generic;

namespace ProjectKingdoM
{
    class EventData // Classcontains all information and value changes for speccific events 
    {
        List<SingleEvent> ListOfEvents = new List<SingleEvent>(); //List containing ALL events possible in the game. 

        public EventData()//If one wants a new event they will write one in the constructor. 
            //SingleEvent/Tuple strructure is string, string, int (actChurchValue), int(actPopulationValue), int(actTreasureActValue) int(, int, int, int, int
        {
            ListOfEvents.Add(new SingleEvent(
                "Trade guild",
                "\nThe merchants in the capital request you to invest in a new trade guild to boost the economy." +
                "Building a new guild will increase the treasury at the expense of the armt and church.",-3, 0, +10, -5, 3, 0, 1, 0));

            ListOfEvents.Add(new SingleEvent(
                "Shipyard", "The army  want to build a new military wharf in your emprie to expand their influence. " +
                "Building a new wharf will upset the peasant and drain the treasury heavily.",
                0, -6, -15, 25, 0, 0, 0, 0));

            ListOfEvents.Add(new SingleEvent("Cathderal", "The Pope of Knirkistan sends a letter urgeing you  to build a new cathedral. " +
                "Buildinga cathdral will negativly impact the peoples will, the army and the treasury. Addotionally, " +
                "refusing to build a cathderal may cause the church to rebell against you. ", 50, -6, -7, -5, -50, 2, 6, 10));

            ListOfEvents.Add(new SingleEvent("Feast", "The city councils want to arange a big feast in celebration for your achievements." +
                "Arranging a feast will increase your popularity with the people but drain your personal treasury. ", 0, 25, -10, 1, 0, 0, 0, 0));
        }
        public List<SingleEvent> ReturnEvents() //Returns the events
        {
            return ListOfEvents;
        }

    }
}
