using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame_version_2
{
    class TradingTerminal
    {
        public static void MainMenu(Status status, Planet planet)
        {

            
            
            

            
            
        }

        public static void Sell(Status status, Planet planet)
        {
            do
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Credits: {status.currency} Age: {status.age}");
                Console.SetCursorPosition(35, 0);
                Console.WriteLine($"Welcome to the Trade Terminal in {planet.planetName}");
                Console.SetCursorPosition(100, 0);
                Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");

                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Please select which item you want to purchase");
                for (int i = 0; i < items.Length; i++)
                {
                    Console.Write($"{i + 1}) {items[i]}: ");
                    Console.WriteLine(terminalItems[i]);
                }
                Console.WriteLine("6) Return to Trade Terminal Main Menu");
                int userInput = Convert.ToInt32(Console.ReadLine());

                --status.totalTrades;
                if (userInput == 1)
                {
                    status.currency -= items[0];
                    playerInventory.Add(terminalItems[0]);
                    playerInventoryPrice.Add(items[0]);
                    status.inventorySize++;
                    Console.Clear();
                    Console.WriteLine("\n***High-Grade Fuel has been added to your inventory!***");
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Credits: {status.currency} Age: {status.age}");
                    Console.SetCursorPosition(35, 0);
                    Console.WriteLine($"Welcome to the Trade Terminal in Alpha Centuria 1");
                    Console.SetCursorPosition(100, 0);
                    Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");
                }


            } while (true);// change this!!
        }

        public static void Purchase(Status status, Planet planet)
        {

        }

        public static void Exit()
        {

        }

        

    }
}
