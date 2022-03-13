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
        /// <summary>
        /// Constructor inicializing the database LocationsDB
        /// </summary>
        public DirectionMaker()
        {
            database = new LocationsDB();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database with coordinates
        /// </summary>
        public void AddLocationWithCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text;
            while (string.IsNullOrEmpty(text = Console.ReadLine()))
            {
                Console.WriteLine("Name cannot be empty, please insert name again");
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
            double distance;
            Console.WriteLine("Insert coordinate distance from default point");
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Please insert number / decimal number only");
            }
            database.AddLoaction(text,x,y,distance);
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database without coordinates
        /// </summary>
        public void AddLocationWithoutCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text;
            while (string.IsNullOrEmpty(text = Console.ReadLine()))
            {
                Console.WriteLine("Name cannot be empty, please insert name again");
            }
            double distance;
            Console.WriteLine("Insert coordinate distance from default point");
            while (!double.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Please insert number / decimal number only");
            }
            database.AddLoaction(text, distance);
        }

    } 
}
