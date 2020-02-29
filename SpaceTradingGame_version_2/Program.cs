using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows;

namespace SpaceTradingGame_version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Status status = new Status();
            Ship ship = new Ship();
            Planet planet = new Planet();
            Ship.ShipInterface(status,planet);

            
        }
    }
}
