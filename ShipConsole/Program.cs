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
            Console. ForegroundColor = ConsoleColor. Red;
            Console.WriteLine("Welcome to ship load game!");
            Console. ForegroundColor = ConsoleColor. White;
            
            Ship NewShip = new Ship();

            //while (NewShip.OverUnder != 0 )
                
            while (NewShip.Diafora() != 0)
	{
            

            Console.WriteLine("Πάμε !" );
            
            /*
            Console.WriteLine("The ship has " + NewShip.CyclesCount + " motorcycles");
            Console.WriteLine("The ship has " + NewShip.CarsCount + " cars");
            Console.WriteLine("The ship has " + NewShip.TrucksCount + " trucks");
            Console.WriteLine("The ship has " + NewShip.TrainsCount + " trains"); */

            
            Console.WriteLine("Diafora "  + NewShip.Diafora());    
                
                     
            Console.WriteLine("The ship has capacity of "  + NewShip.Capacity);    
            Console.WriteLine("Δώσε πόσα motorcycles: ");
            NewShip.CyclesCount= int.Parse(Console.ReadLine());
            Console.WriteLine("Δώσε πόσα Cars: ");
            NewShip.CarsCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Δώσε πόσα Trucks: ");
            NewShip.TrucksCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Δώσε πόσα Trains: ");
            NewShip.TrainsCount = int.Parse(Console.ReadLine());



            Console.WriteLine("The ship has " + NewShip.CyclesCount + " motorcycles - 3 points");
            Console.WriteLine("The ship has " + NewShip.CarsCount + " cars - 5 points");
            Console.WriteLine("The ship has " + NewShip.TrucksCount + " trucks - 11 points");
            Console.WriteLine("The ship has " + NewShip.TrainsCount + " trains - 17 points");

            Console.WriteLine("Το φορτίο τώρα είναι:  " + NewShip.GetShipLoad() );
            Console.WriteLine("Overload ?:  " + NewShip.OverUnder());

            Console.WriteLine("Η διαφορά είναι:  " + NewShip.Diafora());
            Console.ReadLine();
       
	}


            
            Console. ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
             Console.WriteLine("Τα κατάφερες ξεφτίλα !  " );
            
                        Console.ReadLine();


        }
    }
}
