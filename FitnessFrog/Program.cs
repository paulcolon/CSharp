﻿using System;
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
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {

                    var minutes = int.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + "is not an acceptable value");
                        continue;
                    }

                    if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                       else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }
                    // Add minutes exercised to total
                    runningTotal = runningTotal + minutes;


                    // Display total minutes exercised to the screen
                    Console.WriteLine("You've enterd" + runningTotal + "minutes");

                    // Repeat until the user quits
                }
                Console.WriteLine("Goodbye");
            }
        }
    }
}