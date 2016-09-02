using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TV Station
            TVstation Station = new TVstation();
            Station.Navn = "TV2";
            Station.URL = "http://www.tv2.dk";

            // Nyt program
            TVProgram Program = new TVProgram();
            Program.Titel = "Festen";
            Program.StartTidspunkt = new DateTime(2016, 12, 24, 14, 30, 0);
            Program.Station = Station;
          
            // Hvad er oprettet?
            Console.WriteLine(Program.Udskriv());

            // Find URL på station
            Console.WriteLine();
            Console.WriteLine("Url på " + Program.Station.Navn + " er " + Program.Station.URL);
            Console.ReadLine();
        }

        public class TVProgram {
            public string Titel;
            public DateTime StartTidspunkt;
            public TVstation Station;

            // metode til at udskrive oplysninger om programmet
            public string Udskriv()
            {
                string temp;
                    temp = string.Format("Titel  : {0}{1}", Titel, "\n");
                    temp += string.Format("Start  : {0:F}{1}", StartTidspunkt, "\n");
                    temp += string.Format("Station  : {0}", Station.Navn);
                return temp;
            }
        }

        public class TVstation
        {
            public string Navn;
            public string URL;
        }
    }
}
