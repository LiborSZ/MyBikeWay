using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class UserInterfaceControl
    {
        /// <summary>
        /// Instance of LocationDbUserControl
        /// </summary>
        LocationDbUserControl locationUser;
        /// <summary>
        /// Instance of current date and time.
        /// </summary>
        private DateTime currentDate = DateTime.Now;
        /// <summary>
        /// Instance of DirectionMaker
        /// </summary>
        DirectionMaker direction;
        /// <summary>
        /// Constructor inicializating LocationDbUserControl and DirectionMaker classes
        /// </summary>
        public UserInterfaceControl()
        {
            locationUser = new LocationDbUserControl();
        }
        /// <summary>
        /// Opening graphic interface
        /// </summary>
        public void OpeningInterface()
        {
            Console.WriteLine("\n--------------------Welcome in the MyBikeWay application--------------------");
            Console.WriteLine("This application was created to save locations and make directions from them");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Locations Database");
            Console.WriteLine("------------------");
            Console.WriteLine("Please select operation: \n1 - Create new Location with coordinates \n2 - Create new location without coordinates" +
                "\n3 - Remove location \n4 - Update location \n5 - Show saved locations \n6 - Switch to direction making \n7 - Exit");

        }
        /// <summary>
        /// Direction graphic interface
        /// </summary>
        public void DirectionInterface()
        {
            Console.WriteLine("\n--------------------Welcome in the MyBikeWay application--------------------");
            Console.WriteLine("This application was created to save locations and make directions from them");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Directions making");
            Console.WriteLine("-----------------");
            Console.WriteLine("Please select operation: \n1 - Create and add into directions new Location with coordinates " +
                "\n2 - Create and add into directions new location without coordinates" +
                "\n3 - Adding existing location into directions \n4 - Remove location from directions \n5 - Show direction \n6 - Switch to locations" +
                " \n7 - Exit");

        }
        /// <summary>
        /// Start method for launching the application
        /// </summary>
        public void Start()
        {
            Console.Clear();
            OpeningInterface();
            int key = 0;
            Console.Write("Operation: ");
            key = ValidationMethods.IntValid(key);
            while (key != 7)
            {
                switch (key)
                {
                    case 1:
                        locationUser.AddLocationWithCoordinatesNoDistance();
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 2:
                        locationUser.AddLocationWithoutCoordinatesNoDistance();
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 3:
                        locationUser.RemoveLocationDB();
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 4:
                        locationUser.UpdateLocation();
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 5:
                        locationUser.WriteLocationsInDb(); ;
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 6:
                        DirectionControl();
                        break;
                    default:
                        Console.WriteLine("please enter correct operation number");
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                }
            }

        }
        /// <summary>
        /// Method for direction making operations
        /// </summary>
        public void DirectionControl()
        {
            Console.Clear ();
            DirectionInterface();
            int key = 0;
            Console.Write("Operation: ");
            key = ValidationMethods.IntValid(key);
            while (key != 7)
            {
                switch (key)
                {
                    case 1:
                        direction.AddLocationDirection(true);
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 2:
                        direction.AddLocationDirection(false);
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 3:
                        direction.AddExistingLocation();
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 4:
                        direction.RemoveLocationDirection();
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 5:
                        direction.WriteDirection();
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                    case 6:
                        Start();
                        break;
                    default:
                        Console.WriteLine("please enter correct operation number");
                        Console.Write("Operation: ");
                        key = ValidationMethods.IntValid(key);
                        break;
                }
            }
        }
    }
}
