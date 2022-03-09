using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// <param name="distance">Distance from default point</param>
        public void AddLoaction(string name, double coordinateX, double coordinateY, double distance)
        {
            locations.Add(new Location(name, coordinateX, coordinateY, distance));
        }
        /// <summary>
        /// Method to add locatiod into list based on name and distance params
        /// </summary>
        /// <param name="name">Location name</param>
        /// <param name="distance">Distance from default point</param>
        public void AddLoaction(string name, double distance)
        {
            locations.Add(new Location(name, distance));
        }
        /// <summary>
        /// LINQ query to find and return location by name
        /// </summary>
        /// <param name="name">Location name</param>
        /// <returns>Location if found</returns>
        public Location FindLocation (string name)
        {
            
            var locationQuery = from loc in locations
                                where loc.Name == name
                                select loc;
            foreach (Location loc in locationQuery)
            {
                    return loc;
            }
            Console.Write("Location was not found");
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
                if(loc.Name == name)
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
        }
}
