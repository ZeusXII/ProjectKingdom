using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class EventData
    {
        List<SingleEvent> ListOfTupleEvents = new List<SingleEvent>(); //List of events

        public EventData()// List containing every type of event including parameters
        {

            ListOfTupleEvents.Add(new SingleEvent("kyrka", "Info", 10, 4, 6, -6)); //An possible event
            ListOfTupleEvents.Add(new SingleEvent("hus", "Info", 8, 4, 2, -10));

        }
        public List<SingleEvent> ReturnEvents() //Returns the events
        {
            return ListOfTupleEvents;
        }

    }
}
