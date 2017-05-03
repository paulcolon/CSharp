using System;
using System.Collections.Generic;

namespace FitnessFrog
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var runningTotal = 0;
            // Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised");
            int entry  = Console.ReadLine();
            int minutes = int.Parse(entry);
            runningTotal = runningTotal + minutes;

            // Add minutes exercised to total
            // Display total minutes exercised to the screen
            Console.WriteLine("You've enterd" + runningTotal + "minutes");
            // Repeat until the user quits

        }
    }
}