using System;

namespace ProjectKingdoM
{
    class Program
    {
        static void Main(string[] args)
        {
            Kingdom A = new Kingdom();

            //Exempel på tuple nedan
            var buildChurch = new Tuple<string, string, int, int, int, int>("Headline", "Info", 10, 4, 6, -6); 
            
            A.Events.Add(buildChurch);
            Console.WriteLine("Hello World!" + A.Events);

            Console.ReadKey();
        }

        
    }
}
