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
        /// Instance of LocationsDB class
        /// </summary>
        private LocationsDB database;
        public string Name { get; private set; }
        /// <summary>
        /// Instance of LocationDbUserControl class
        /// </summary>
        private LocationDbUserControl dbControl;
        /// <summary>
        /// Instance of ValidationMethods Class
        /// </summary>
        private ValidationMethods validator;
        /// <summary>
        /// Linked list for direction
        /// </summary>
        private LinkedList<Location> directions;
        /// <summary>
        /// Constructor inicializing DB, user, validation classes and linked list
        /// </summary>
        public DirectionMaker(string name)
        {
            Name = name;
            database = new LocationsDB();
            directions = new LinkedList<Location>();
            validator = new ValidationMethods();
            dbControl = new LocationDbUserControl();
        }
        /// <summary>
        /// Add location into direction linked list or DB
        /// </summary>
        /// <param name="withCoordinates"></param>
        public void AddLocationDirection(bool withCoordinates)
        {  
                if (withCoordinates)
                {
                    directions.AddLast(dbControl.AddLocationWithCoordinates());
                }
                else
                {
                    directions.AddLast(dbControl.AddLocationWithoutCoordinates());
                }
            
        }
        /// <summary>
        /// Writes information about direction from linked list
        /// </summary>
        public void WriteDirection()
        {
            double directionDistance=0;
            double totalDistance =0;
            
            Console.WriteLine("Your direction:");
            
            foreach (var d in directions)
            {

                totalDistance += d.PreviousPointDistance;
                directionDistance = d.PreviousPointDistance;
                
                Console.Write($"{char.ToUpper(d.Name[0])+ d.Name.Substring(1)} ({directionDistance} Km)");
                if (d.Name != directions.Last.Value.Name)
                {
                    Console.Write(" - ");
                }
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
        /// Add location into direction based on existing location
        /// </summary>
        /// <param name="name"></param>
        public void AddExistingLocation()
        {
            string name ="";
            validator.EmptyStringValid(name);
            directions.AddLast(database.FindLocation(name));
        }


        
    } 
    
}
