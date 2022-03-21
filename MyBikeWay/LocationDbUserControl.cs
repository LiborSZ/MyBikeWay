using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class LocationDbUserControl
    {
        /// <summary>
        /// Instance of ValidationMethods Class
        /// </summary>
        ValidationMethods validator;
        /// <summary>
        /// Instance of LocationsDB class
        /// </summary>
        LocationsDB database;
        /// <summary>
        /// Constructor initializing valid and location database classes
        /// </summary>
        public LocationDbUserControl()
        {
            validator = new ValidationMethods();
            database = new LocationsDB();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database with coordinates
        /// </summary>
        public Location AddLocationWithCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text = "";
            validator.EmptyStringValid(text);
            double distance = 0;
            Console.WriteLine("Insert distance from previous point (insert 0 if default point)");
            distance = validator.DoubleValid(distance);
            Console.WriteLine("Insert coordinate X");
            double x = 0;
            x = validator.DoubleValid(x);
            double y = 0;
            Console.WriteLine("Insert coordinate Y");
            y = validator.DoubleValid(y);

            database.AddLoaction(text, x, y, distance);
            return database.returnLast();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database without coordinates
        /// </summary>
        public Location AddLocationWithoutCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text = "";
            text = validator.EmptyStringValid(text);
            double distance = 0;
            Console.WriteLine("Insert distance from previous point (insert 0 if default point)");
            distance = validator.DoubleValid(distance);
            database.AddLoaction(text, distance);
            return database.returnLast();
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
        /// Method for location atribute update
        /// </summary>
        /// <param name="name"></param>
        public void UpdateLocation()
        {
            string name = "";
            name = validator.StringValid(name);
            string attribute = "";
            string newName = "";
            double newCoordinate = 0;
            Console.WriteLine("Name | Distance | Location X | Location Y | Exit");
            Console.WriteLine("Enter attribute to update or exit: ");

            Console.WriteLine(attribute);
            attribute = validator.StringValid(attribute);
            switch (attribute)
            {
                case "name":
                    validator.EmptyStringValid(newName);
                    database.UpdateLocationName(name, newName);
                    break;
                case "distance":
                    validator.DoubleValid(newCoordinate);
                    database.UpdateLocationDistance(name, newCoordinate);
                    break;
                case "location x":
                    validator.DoubleValid(newCoordinate);
                    database.UpdateLocationDistance(name, newCoordinate);
                    break;
                case "location y":
                    validator.DoubleValid(newCoordinate);
                    database.UpdateLocationDistance(name, newCoordinate);
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Enter correct attribute to update or exit");
                    break;

            }

        }

    }
}
