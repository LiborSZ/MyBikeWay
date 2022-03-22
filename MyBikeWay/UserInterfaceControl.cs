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

        public void OpeningInterface()
        {
            Console.WriteLine("\n--------------------Welcome in the MyBikeWay application--------------------");
            Console.WriteLine("This application was created to save locations and make directions from them");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Locations Database");
            Console.WriteLine("------------------");
            Console.WriteLine("Please select operation: \n1 - Create new Location with coordinates \n2 - Create new location without coordinates" +
                "\n3 - Remove location \n4 - Update location \n5 - Switch to direction making \n6 - Show saved locations \n7 - Exit");
            
        }

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

        public void Start()
        {
            Console.Clear();
            OpeningInterface();
            int key = 0;
            while (key != 7)
            {
                switch (key)
                {
                    case 1:
                        locationUser.AddLocationWithCoordinates();
                        break;
                    case 2:
                        locationUser.AddLocationWithoutCoordinates();
                        break;
                    case 3:
                        locationUser.RemoveLocationDB();
                        break;

                }
            }
            
        }


    }
}
