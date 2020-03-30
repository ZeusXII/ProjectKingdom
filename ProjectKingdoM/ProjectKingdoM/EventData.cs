using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class EventData
    {
        List<SingleEvent> ListOfTupleEvents = new List<SingleEvent>(); //List of events

        public EventData()// Adds events to list containing all types of events. It's here events are created as they are "static".
        {

            //ListOfTupleEvents.Add(new SingleEvent("kyrka", "Info", 10, 4, 6, -6));
            //ListOfTupleEvents.Add(new SingleEvent("hus", "Info", 8, 4, 2, -10));

            // Title, description, church, population, treasure, army
            ListOfTupleEvents.Add(new SingleEvent(
                "Trade guild",
                "\nThe merchants in the capital request you to invest in a new trade guild to boost the economy." +
                "Building a new guild will increase the treasury at the expense of the armt and church.",-3, 0, +10, -5));

            ListOfTupleEvents.Add(new SingleEvent(
                "Shipyard", "The army  want to build a new military wharf in your emprie to expand their influence. " +
                "Building a new wharf will upset the peasant and drain the treasury heavily.",
                0, -6, -15, 25));

            ListOfTupleEvents.Add(new SingleEvent("Cathderal", "The Pope of Knirkistan sends a letter urgeing you  to build a new cathedral. " +
                "Buildinga cathdral will negativly impact the peoples will, the army and the treasury. Addotionally, " +
                "refusing to build a cathderal may cause the church to rebell against you. ", -50, -6, -7, -5));

            ListOfTupleEvents.Add(new SingleEvent("Feast", "The city councils want to arange a big feast in celebration for your achievements." +
                "Arranging a feast will increase your popularity with the people but drain your personal treasury. ", 0, 25, -10, 1));



        }
        public List<SingleEvent> ReturnEvents() //Returns the events
        {
            return ListOfTupleEvents;
        }

    }
}
