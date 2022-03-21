﻿using System;
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
        private ValidationMethods validator;
        /// <summary>
        /// Instance of current date and time.
        /// </summary>
        private DateTime currentDate = DateTime.Now;
        /// <summary>
        /// Linked list for direction
        /// </summary>
        private LinkedList<Location> directions;
        /// <summary>
        /// Constructor inicializing the database LocationsDB
        /// </summary>
        public DirectionMaker()
        {
            database = new LocationsDB();
            directions = new LinkedList<Location>();
            validator = new ValidationMethods();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database with coordinates
        /// </summary>
        public Location AddLocationWithCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text ="";
            validator.EmptyStringValid(text);
            double distance =0;
            Console.WriteLine("Insert distance from previous point (inser 0 if default point)");
            validator.DoubleValid(distance);
            Console.WriteLine("Insert coordinate X");
            double x =0;
            validator.DoubleValid(x);
            double y=0;
            Console.WriteLine("Insert coordinate Y");
            validator.DoubleValid(y);

            database.AddLoaction(text, x, y, distance);
            return database.returnLast();
        }
        /// <summary>
        /// Method for getting user input for adding new location to the database without coordinates
        /// </summary>
        public Location AddLocationWithoutCoordinates()
        {
            Console.WriteLine("Insert location name");
            string text="";
            validator.EmptyStringValid(text);
            double distance =0;
            Console.WriteLine("Insert coordinate distance from previous point");
            validator.DoubleValid(distance);
            database.AddLoaction(text, distance);
            return database.returnLast();
        }
        /// <summary>
        /// Add location into direction linked list or DB
        /// </summary>
        /// <param name="withCoordinates"></param>
        public void AddLocationDirection(bool withCoordinates)
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
                
                Console.Write($"{char.ToUpper(d.Name[0])+ d.Name.Substring(1)} - {directionDistance} Km ");
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
        public void AddExistingLocation()
        {
            string name ="";
            validator.EmptyStringValid(name);
            directions.AddLast(database.FindLocation(name));
        }

        /// <summary>
        /// Method for location atribute update
        /// </summary>
        /// <param name="name"></param>
        public void UpdateLocation()
        {
            string name ="";
            name = validator.StringValid(name);
            string attribute ="";
            string newName ="";
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
