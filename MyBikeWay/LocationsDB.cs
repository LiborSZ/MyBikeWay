using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBikeWay
{
    internal class LocationsDB
    {
        /// <summary>
        /// Private instance for List of locations
        /// </summary>
        private List<Location> locations;
        /// <summary>
        /// Constructor creating new List of locations
        /// </summary>
        public LocationsDB()
        {
            locations = new List<Location>();
        }
        /// <summary>
        /// Method to add locatiod into list based on all params
        /// </summary>
        /// <param name="name">Location name</param>
        /// <param name="coordinateX">Location coordinate X</param>
        /// <param name="coordinateY">Location coordinate Y</param>
        /// <param name="distance">Distance from previous point</param>
        public void AddLoaction(string name, double coordinateX, double coordinateY, double distance)
        {
            locations.Add(new Location(name, coordinateX, coordinateY, distance));
            
        }
        /// <summary>
        /// Method to add locatiod into list based on name and distance params
        /// </summary>
        /// <param name="name">Location name</param>
        /// <param name="distance">Distance from previous point</param>
        public void AddLoaction(string name, double distance)
        {
            locations.Add(new Location(name, distance));

        }
        /// <summary>
        /// LINQ query to find and return location by name
        /// </summary>
        /// <param name="name">Location name</param>
        /// <returns>Location if found</returns>
        public Location FindLocation(string name)
        {

            var locationQuery = from loc in locations
                                where loc.Name == name
                                orderby loc.PreviousPointDistance
                                select loc;
            foreach (Location loc in locationQuery)
            {
                return loc;
            }
            Console.WriteLine("Location was not found");
            return null;

        }
        /// <summary>
        /// Removing method for locations DB
        /// </summary>
        /// <param name="name">Location name</param>
        public void DeleteLocation(string name)
        {
            List<Location> found = new List<Location>();
            found.Add(FindLocation(name));
            foreach (Location loc in found)
            {
                if (loc.Name == name)
                {
                    locations.Remove(loc);
                    Console.WriteLine("Location {0} removed", name);
                }
                else
                {
                    Console.Write("Location was not found");
                }
            }

        }
        /// <summary>
        /// Name update method based on name
        /// </summary>
        /// <param name="name">Current name</param>
        /// <param name="newName">New name</param>
        public void UpdateLocationName(string name, string newName)
        {
          var locationQuery = locations.Find(n => n.Name == name);
          if (locationQuery != null)
            {
                locationQuery.Name = newName;
            }
        }
        /// <summary>
        /// Coordinate X update method based on name
        /// </summary>
        /// <param name="name">Current name</param>
        /// <param name="newCoordinateX">New coordinateX decimal number</param>
        public void UpdateLocationX(string name, double newCoordinateX)
        {
            var locationQuery = locations.Find(n => n.Name == name);
            if (locationQuery != null)
            {
                locationQuery.CoordinateX = newCoordinateX;
            }
        }
        /// <summary>
        /// Coordinte Y update method based on name
        /// </summary>
        /// <param name="name">Current name</param>
        /// <param name="newCoordinateY">New coordinate Y decimal number</param>
        public void UpdateLocationY(string name, double newCoordinateY)
        {
            var locationQuery = locations.Find(n => n.Name == name);
            if (locationQuery != null)
            {
                locationQuery.CoordinateY = newCoordinateY;
            }
        }
        /// <summary>
        /// Distance from previous point update method based on name
        /// </summary>
        /// <param name="name">Current name</param>
        /// <param name="newDefaultPoint">New distance decimal number (Km)</param>
        public void UpdateLocationDistance(string name, double newPreviousPoint)
        {
            var locationQuery = locations.Find(n => n.Name == name);
            if (locationQuery != null)
            {
                locationQuery.PreviousPointDistance = newPreviousPoint;
            }
        }
        /// <summary>
        /// Returns last added location into List of locations
        /// </summary>
        /// <returns></returns>
        public Location returnLast()
        {
            return locations.Last();
        }
    }
}
