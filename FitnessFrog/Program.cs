using System;
using System.Collections.Generic;

namespace FitnessFrog
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;


            while (keepGoing)
            {
                // Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised");
                var entry = Console.ReadLine();
                var minutes = int.Parse(entry);
                runningTotal = runningTotal + minutes;

                // Add minutes exercised to total
                // Display total minutes exercised to the screen
                Console.WriteLine("You've enterd" + runningTotal + "minutes");
                // Repeat until the user quits
            }
        }
    }
}