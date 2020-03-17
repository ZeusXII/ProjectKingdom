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

            Kingdom A = new Kingdom(); //Creates a new kingdom session

            List<Tuple<string, string, int, int, int, int>> ListOfTupleEvents = new List<Tuple<string, string, int, int, int, int>>();
            A.PresentParameters();

            var buildChurch = new Tuple<string, string, int, int, int, int>("Headline", "Info", 10, 4, 6, -6);
            var buildWarehouse = new Tuple<string, string, int, int, int, int>("Headline", "Info", 10, 4, 96, -6);
            ListOfTupleEvents.Add(buildChurch);
            ListOfTupleEvents.Add(buildWarehouse);

            A = new Event(ListOfTupleEvents[0], A).Act();
            A.PresentParameters();


            //Exemple of a tuple
            var ExamplebuildChurch = new Tuple<string, string, int, int, int, int>("Headline", "Info", 10, 4, 6, -6);
            //A = new Event(buildChurch, A).Act();



            Console.ReadKey();
        }

    }
}
