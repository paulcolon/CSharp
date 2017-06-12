using System;
using System.Runtime.InteropServices;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8 , 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (Exception)
            {
                Console.WriteLine("That map locationis is not on the map!");
            }
        }
    }
}