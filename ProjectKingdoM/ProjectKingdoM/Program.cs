using System;
using System.Collections.Generic;
namespace ProjectKingdoM
{
    class Program
    {
        static void Main(string[] args)
        {
            EventData e = new EventData();
            BaseEmpire B = new BaseEmpire(); //Base empire type class 
            GameHandler gameHandler = new GameHandler(e, B);
            gameHandler.MainLoop();
        }
    }
}

