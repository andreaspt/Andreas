using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipConsole
{
    class Ship
    {
        public int CyclesCount { get; set; }
        public int CarsCount { get; set; }
        public int TrucksCount { get; set; }
        public int TrainsCount { get; set; }
        public int Capacity { get; set; }

        public Random rnd = new Random();

        


        public int getShipLoad()
        {
            int fortio;
            fortio = CyclesCount + CarsCount + TrucksCount + TrainsCount;
            return fortio;
        }
            
        
        public Ship()
        {
            CyclesCount = 0;
            CarsCount = 0;
            TrucksCount = 0;
            TrainsCount = 0;
            Capacity = rnd.Next(10);

        }

            

    }
}
