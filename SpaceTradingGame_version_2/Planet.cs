using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame_version_2
{
    class Planet
    {
        public string planetName;
        public static void Earth()
        {
            (int, int) coodrinates = (0, 0);

            

        }

        public static void AlphaCenturia1(Planet planet)
        {
            (int, int) coordinates = (143, 187);

            string name = "Alpha Centuria 1";
            planet.planetName = name;
            

            List<string> a1Merchandise = new List<string>() { "High-Grade Fuel", "Alpha Centuria Land Deed", "alphaCenturia Residents", "Rifle", "Ship Missiles" };
            List<int> a1MerchandisePrice = new List<int>() { 300, 1000, 500, 200, 3000 };

        }
        
        public static void Tattooine(Planet planet)
        {
            (int, int) coordinates = (250, 140);
            string name = "Tattooine";
            planet.planetName = name;

            List<string> a1Merchandise = new List<string>() { "Low-Grade Fuel", "Tatooine Land Deed", "Tatooine Residents", "Pistol", "Rare Metals" };
            List<int> a1MerchandisePrice = new List<int>() { 100, 500, 150, 50, 1500 };

        }

        public static void Alderan(Planet planet)
        {
            (int, int) coordinates = (164, 300);
            string name = "Alderan";
            planet.planetName = name;
            List<string> a1Merchandise = new List<string>() { "Low-Grade Fuel", "Alderan Land Deed", "Alderan Residents", "art", "cigars" };
            List<int> a1MerchandisePrice = new List<int>() { 1000, 3000, 2500, 2000, 4000 };
        }

        public static void Sentinel(Planet planet)
        {
            (int, int) coordinates = (354, 256);
            string name = "Sentinel";
            planet.planetName = name;
            List<string> a1Merchandise = new List<string>() { "High-Grade Fuel", "Vitamin Water", "Upgraded Navigation System", "Virtual Game Station", "Sentinel Land Deed" };
            List<int> a1MerchandisePrice = new List<int>() { 7000, 3000, 4500, 3000, 75000 };

        }
        
        public static void September(Planet planet)
        {
            (int, int) coordinates = (496, 532);
            string name = "September";
            planet.planetName = name;

            List<string> a1Merchandise = new List<string>() { "High-Grade Fuel", "September Land", "Rifle", "Missiles", "Pistol" };
            List<int> a1MerchandisePrice = new List<int>() { 7000, 10000, 4500, 8000, 1000 };

        }
    }
}
