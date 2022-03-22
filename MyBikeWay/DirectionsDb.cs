using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class DirectionsDb
    {
        /// <summary>
        /// Direaction maker class 
        /// </summary>
        private List<DirectionMaker> directions;
        /// <summary>
        /// Direction maker class initialized
        /// </summary>
        public DirectionsDb()
        {
            directions = new List<DirectionMaker>();
        }
        /// <summary>
        /// Method for adding direction into list
        /// </summary>
        /// <param name="name"></param>
        public void AddDirection(string name)
        {
            directions.Add(new DirectionMaker(name));
        }

        /// <summary>
        /// LINQ query to find and return Direction by name
        /// </summary>
        /// <param name="name">Location name</param>
        /// <returns>Location if found</returns>
        public DirectionMaker FindDirection(string name)
        {

            var DirectionQuery = from direction in directions
                                where direction.Name == name
                                select direction;
            foreach (DirectionMaker direction in DirectionQuery)
            {
                return direction;
            }
            Console.WriteLine("Direction was not found");
            return null;

        }

        /// <summary>
        /// Removing method for directions DB
        /// </summary>
        /// <param name="name">Location name</param>
        public void DeleteDirection(string name)
        {
            List<DirectionMaker> found = new List<DirectionMaker>();
            found.Add(FindDirection(name));
            foreach (DirectionMaker direction in found)
            {
                if (direction.Name == name)
                {
                    directions.Remove(direction);
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
