using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectKingdoM
{
    class EventData
    {
        List<Tuple<string, string, int, int, int, int>> ListOfTupleEvents = new List<Tuple<string, string, int, int, int, int>>();

        public EventData()// List containing every type of event including parameters
        {

            ListOfTupleEvents.Add(new Tuple<string, string, int, int, int, int>("kyrka", "Info", 5510, 4, 6, -6));
            ListOfTupleEvents.Add(new Tuple<string, string, int, int, int, int>("hus", "Info", 100, 4, 96, -10));

        }
        public List<Tuple<string, string, int, int, int, int>> ReturnEvents()
        {
            return ListOfTupleEvents;
        }













        //Examples
        /*
        B = new Event(ListOfTupleEvents[0], B).Act();
        B.PresentParameters();


        Exemple of a tuple
          var ExamplebuildChurch = new Tuple<string, string, int, int, int, int>("Headline", "Info", 10, 4, 6, -6);
        //A = new Event(buildChurch, A).Act();
        */
    }
}
