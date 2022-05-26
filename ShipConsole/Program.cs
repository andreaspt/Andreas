using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to ship load game!");

            Ship NewShip = new Ship();

            Console.WriteLine("The ship has capacity of "  + NewShip.Capacity);
            Console.WriteLine("The ship has " + NewShip.CyclesCount + " motorcycles");
            Console.WriteLine("The ship has " + NewShip.CarsCount + " cars");
            Console.WriteLine("The ship has " + NewShip.TrucksCount + " trucks");
            Console.WriteLine("The ship has " + NewShip.TrainsCount + " trains");




            Console.ReadLine();


        }
    }
}
