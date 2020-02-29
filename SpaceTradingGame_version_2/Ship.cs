using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame_version_2
{
    class Ship
    {
        public static void Inventory(Status status)
        {
            List<string> playerInventory = status.playerInventory;

            for (int i = 0; i< playerInventory.Count; i++)
            {
                Console.WriteLine($"{i+1}) {playerInventory[i]}");
            }

        }

        public static void ShipInterface(Status status, Planet planet)
        {
            Console.WriteLine("Welcome to your ship, Please select from the following:");
            Console.WriteLine("1) Travel" + "\n 2) Check Inventory");
        }
    }
}
