using System;
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
            A.PresentParameters();
            


















            //Exemple of a tuple
            var buildChurch = new Tuple<string, string, int, int, int, int>("Headline", "Info", 10, 4, 6, -6);
            A.Events.Add(buildChurch);
            Console.WriteLine("Hello World!" + A.Events[0]);

            Console.ReadKey();
        }

    }
}
