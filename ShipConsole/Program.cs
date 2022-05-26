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


            //while (NewShip.OverUnder != 0 )
                

            Console.WriteLine("The ship has capacity of "  + NewShip.Capacity);
            Console.WriteLine("The ship has " + NewShip.CyclesCount + " motorcycles");
            Console.WriteLine("The ship has " + NewShip.CarsCount + " cars");
            Console.WriteLine("The ship has " + NewShip.TrucksCount + " trucks");
            Console.WriteLine("The ship has " + NewShip.TrainsCount + " trains");

            Console.WriteLine("Δώσε πόσα motorcycles: ");
            NewShip.CyclesCount= int.Parse(Console.ReadLine());
            Console.WriteLine("Δώσε πόσα Cars: ");
            NewShip.CarsCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Δώσε πόσα Trucks: ");
            NewShip.TrucksCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Δώσε πόσα Trains: ");
            NewShip.TrainsCount = int.Parse(Console.ReadLine());



            Console.WriteLine("The ship has " + NewShip.CyclesCount + " motorcycles");
            Console.WriteLine("The ship has " + NewShip.CarsCount + " cars");
            Console.WriteLine("The ship has " + NewShip.TrucksCount + " trucks");
            Console.WriteLine("The ship has " + NewShip.TrainsCount + " trains");

            Console.WriteLine("Το φορτίο τώρα είναι:  " + NewShip.GetShipLoad() );
            Console.WriteLine("Overload ?:  " + NewShip.OverUnder());



            Console.ReadLine();


        }
    }
}
