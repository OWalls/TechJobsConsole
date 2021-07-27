using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Dictionary<string, string>> band = new List<Dictionary<string, string>>();


            //assign 
            //band.Add("Name", "Fallout Boy"); //not going to work

            Dictionary<string, string> imagineDragons = new Dictionary<string, string>();
            imagineDragons.Add("Lead Singer", "Daniel Sermon");
            imagineDragons.Add("Guitar", "Dan Reynolds");
            imagineDragons.Add("Piano", "DaniiVORY");

            Console.WriteLine("Loop through Imagine Dragons Dictionary of Members: ");
            
            foreach (KeyValuePair<string, string> member in imagineDragons)
            {
                Console.WriteLine("Role: " + member.Key + " - Member: " + member.Value);
            }

            Dictionary<string, string> panicAtTheDisco = new Dictionary<string, string>();
            panicAtTheDisco.Add("Lead Singer", "Brendon Urie");
            panicAtTheDisco.Add("Drum", "Spencer Smith");


            Console.WriteLine("\n" + "Loop through Panic! at the Disco Dictionary of Members: ");

            foreach (KeyValuePair<string, string> member in panicAtTheDisco)
            {
                Console.WriteLine("Role: " + member.Key + " - Member: " + member.Value);
            }
            
            //create a list of Dictionaries

            List<Dictionary<string, string>> bands = new List<Dictionary<string, string>>();

            bands.Add(imagineDragons);
            bands.Add(panicAtTheDisco);

            foreach(Dictionary<string, string> band in bands)
            {
                foreach(string member in band.Keys)
                {
                    Console.WriteLine("\n" + member + " - " + band[member] );
                }
            }

        }
    }
}
