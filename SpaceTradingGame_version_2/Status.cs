using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTradingGame_version_2
{
    class Status
    {
        public int age = 18;
        public int currency = 50000;
        public int totalTrades = 5;
        public int inventorySize = 10;
        public (int, int) coordinates = (0, 0);

        public List<string> playerInventory = new List<string>() { "fruit", "meat", "jewels", "rifles", "pistols", "explosives", "missiles", "land", "residents", "miningTools" };
        public List<int> playerInventoryPrice = new List<int>() { 5, 10, 1000, 1500, 750, 2000, 2500, 5000, 3000, 1000 };



    }
}
