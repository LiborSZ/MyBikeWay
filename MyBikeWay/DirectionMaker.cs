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
        private Location AddLocationWithCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text;
            while (string.IsNullOrEmpty(text = Console.ReadLine()))
            {
                Console.WriteLine("Name cannot be empty, please insert name again");
            }
            Console.WriteLine("Insert coordinate X");
            double distance;
            Console.WriteLine("Insert distance from previous point");
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Please insert number / decimal number only");
            }
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
        private Location AddLocationWithoutCoordinates()
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
        /// Add first point into linked list
        /// </summary>
        /// <param name="withCoordinates"></param>
        public void AddFirstPoint(bool withCoordinates)
        {
            if (withCoordinates)
            {
                directions.AddFirst(AddLocationWithCoordinates());
            }
            else
            {
                directions.AddFirst(AddLocationWithoutCoordinates());
            }
            
        }
      
    } 
}
