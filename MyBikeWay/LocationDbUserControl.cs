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
        /// Instance of LocationsDB class
        /// </summary>
        LocationsDB database;
        /// <summary>
        /// Constructor initializing valid and location database classes
        /// </summary>
        public LocationDbUserControl()
        {
            database = new LocationsDB();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database with coordinates
        /// </summary>
        public Location AddLocationWithCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text = "";
            text = ValidationMethods.EmptyStringValid(text);
            double distance = 0;
            Console.WriteLine("Insert distance from previous point (insert 0 if default point)");
            distance = ValidationMethods.DoubleValid(distance);
            Console.WriteLine("Insert coordinate X");
            double x = 0;
            x = ValidationMethods.DoubleValid(x);
            double y = 0;
            Console.WriteLine("Insert coordinate Y");
            y = ValidationMethods.DoubleValid(y);

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
            text = ValidationMethods.EmptyStringValid(text);
            double distance = 0;
            Console.WriteLine("Insert distance from previous point (insert 0 if default point)");
            distance = ValidationMethods.DoubleValid(distance);
            database.AddLoaction(text, distance);
            return database.returnLast();
        }

        /// <summary>
        /// Method for removing location from DB based on name
        /// </summary>
        /// <param name="name"></param>
        public void RemoveLocationDB()
        {
            database.DeleteLocation();
        }

        /// <summary>
        /// Method for location atribute update
        /// </summary>
        /// <param name="name"></param>
        public void UpdateLocation()
        {
            string name = "";
            Console.WriteLine("Please enter location name to update: ");
            Console.Write("Name: ");
            name = ValidationMethods.StringValid(name);
            if (database?.FindLocation(name) != null)
            {
                string attribute = "";
                string newName = "";
                double newCoordinate = 0;
                Console.WriteLine("Name | Distance | Location X | Location Y | Exit");
                Console.WriteLine("Enter attribute to update or exit: ");
                Console.Write("Attribute: ");
                attribute = ValidationMethods.StringValid(attribute);
                switch (attribute)
                {
                    case "name":
                        Console.Write("Select new name: ");
                        newName = ValidationMethods.EmptyStringValid(newName);
                        database.UpdateLocationName(name, newName);
                        break;
                    case "distance":
                        Console.Write("Select new distance: ");
                        newCoordinate = ValidationMethods.DoubleValid(newCoordinate);
                        database.UpdateLocationDistance(name, newCoordinate);
                        break;
                    case "location x":
                        Console.Write("Select new location x: ");
                        newCoordinate = ValidationMethods.DoubleValid(newCoordinate);
                        database.UpdateLocationDistance(name, newCoordinate);
                        break;
                    case "location y":
                        Console.Write("Select new location y: ");
                        newCoordinate = ValidationMethods.DoubleValid(newCoordinate);
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
        /// <summary>
        /// Write all locations in database to the console
        /// </summary>
        public void WriteLocationsInDb()
        {
            Console.WriteLine(database.ReturnAll());
        }

    }
}
