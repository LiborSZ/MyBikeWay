using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class DirectionMaker
    {
        /// <summary>
        /// Instance of LocationsDB databse
        /// </summary>
        private LocationsDB database;
        /// <summary>
        /// Instance of current date and time.
        /// </summary>
        private DateTime currentDate = DateTime.Now;
        private LinkedList<Location> directions;
        /// <summary>
        /// Constructor inicializing the database LocationsDB
        /// </summary>
        public DirectionMaker()
        {
            database = new LocationsDB();
            directions = new LinkedList<Location>();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database with coordinates
        /// </summary>
        public Location AddLocationWithCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text;
            while (string.IsNullOrEmpty(text = Console.ReadLine()))
            {
                Console.WriteLine("Name cannot be empty, please insert name again");
            }
            double distance;
            Console.WriteLine("Insert distance from previous point (inser 0 if default point)");
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Please insert number / decimal number only");
            }
            Console.WriteLine("Insert coordinate X");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Please insert number / decimal number only");
            }
            double y;
            Console.WriteLine("Insert coordinate Y");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Please insert number / decimal number only");
            }

            database.AddLoaction(text, x, y, distance);
            return database.returnLast();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database without coordinates
        /// </summary>
        public Location AddLocationWithoutCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text;
            while (string.IsNullOrEmpty(text = Console.ReadLine()))
            {
                Console.WriteLine("Name cannot be empty, please insert name again");
            }
            double distance;
            Console.WriteLine("Insert coordinate distance from previous point");
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Please insert number / decimal number only");
            }
            database.AddLoaction(text, distance);
            return database.returnLast();
        }
        /// <summary>
        /// Add location into direction linked list or DB
        /// </summary>
        /// <param name="withCoordinates"></param>
        public void AddLocationDirection(bool db, bool withCoordinates)
        {  
                if (withCoordinates)
                {
                    directions.AddLast(AddLocationWithCoordinates());
                }
                else
                {
                    directions.AddLast(AddLocationWithoutCoordinates());
                }
            
        }
        /// <summary>
        /// Writes information about direction from linked list
        /// </summary>
        public void WriteDirection()
        {
            double directionDistance = 0;
            double totalDistance = 0;
            Console.WriteLine("Your direction:");
            foreach (var d in directions)
            {
                totalDistance += d.PreviousPointDistance;
                directionDistance = d.PreviousPointDistance;
                
                Console.Write($"{d.Name} - {directionDistance} Km ");
            }
            Console.WriteLine();
            Console.WriteLine($"Total distance is {totalDistance} Km");

        }
        /// <summary>
        /// Method for removing location from direction based on name
        /// </summary>
        /// <param name="name"></param>
        public void RemoveLocationDirection(string name)
        {
            directions.Remove(database.FindLocation(name));
        }
        /// <summary>
        /// Method for removing location from DB based on name
        /// </summary>
        /// <param name="name"></param>
        public void RemoveLocationDB(string name)
        {
            database.DeleteLocation(name);
        }
        /// <summary>
        /// Add location into direction based on existing location
        /// </summary>
        /// <param name="name"></param>
        public void AddExistingLocation(string name)
        {
            directions.AddLast(database.FindLocation(name));
        }


        
    } 
    
}
