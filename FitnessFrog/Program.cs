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
            var entry  = Console.ReadLine();

            // Add minutes exercised to total
            // Display total minutes exercised to the screen
            Console.WriteLine("You've enterd" + entry + "minutes");
            // Repeat until the user quits

        }
    }
}