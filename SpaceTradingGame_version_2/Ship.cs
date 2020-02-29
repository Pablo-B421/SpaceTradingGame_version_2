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

            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Credits: {status.currency} Age: {status.age}");

            for (int i = 0; i< playerInventory.Count; i++)
            {
                Console.WriteLine($"{i+1}) {playerInventory[i]}");
            }

        }

        public static void ShipInterface(Status status, Planet planet)
        {
            Console.WriteLine("Welcome to your ship, Please select from the following:");
            Console.WriteLine("\n1)Check Inventory" + "\n2) Travel");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                Inventory(status);
                Console.WriteLine("\n ***Press <Enter> to return to the ship menu***");
                Console.ReadLine();
                do
                {
                    Console.Clear();
                    ShipInterface(status,planet);
                }
                while (Console.ReadKey().Key != ConsoleKey.Enter);

            }
            else if (input == "2")
            {
                Console.Clear();
                Console.Write("Travel To: ");
                Console.WriteLine("\n(1) Alpha Centuria" + "\n(2) Tatooine" + "\n(3) Alderan" + "\n(4) Sentinel" + "\n(5) September");
                int travel = int.Parse(Console.ReadLine());

                switch (travel)
                {
                    case 1:
                        status.coordinates = (183, 147);
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.White;
                        Planet.AlphaCenturia1(planet);
                        TravelMenu(status,planet);
                        Console.WriteLine("\nWelcome to Alpha Centuria, a low income planet. Feel free to trade at your leisure.");
                        TradingTerminal.MainMenu(status, planet);
                        break;
                    case 2:
                        status.coordinates = (250, 140);
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Welcome to Tatooine, you've arrived to a desert planet.");
                       // tradingTerminal.TerminalMenu(status);
                        // tradingTerminal.Sell(status);
                        // Console.ReadLine();
                        break;
                    case 3:
                        status.coordinates = (164, 300);
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Welcome to Alderan, a planet full of life, actvity, and space pirates.");
                        //tradingTerminal.TerminalMenu(status);
                        // Console.ReadLine();
                        break;
                    case 4:
                        status.coordinates = (354, 256);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Welcome to Sentinel, a highly advanced civilization resides here.");
                       // tradingTerminal.TerminalMenu(status);
                        //Console.ReadLine();
                        break;
                    case 5:
                        status.coordinates = (496, 532);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Clear();
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Welcome to September, home of the Space Police Academy.");
                        //tradingTerminal.TerminalMenu(status);
                        // Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter only 1 or 2.");
                Console.Clear();
                ShipInterface(status,planet);
            }



        }

        private static void TravelMenu(Status status, Planet planet)
        {
            
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Credits: {status.currency} Age: {status.age}");
            Console.SetCursorPosition(35, 0);
            Console.WriteLine($"Welcome to the Trade Terminal in {planet.planetName}");
            Console.SetCursorPosition(100, 0);
            Console.WriteLine($"Moves Remaining : {status.totalTrades - 5}");
            Console.SetCursorPosition(0, 1);
        }
    }
}
