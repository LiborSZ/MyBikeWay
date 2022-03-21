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
        /// Instance of DirectionMaker
        /// </summary>
        DirectionMaker direction;
        /// <summary>
        /// Constructor inicializating LocationDbUserControl and DirectionMaker classes
        /// </summary>
        public UserInterfaceControl()
        {
            locationUser = new LocationDbUserControl();
            direction = new DirectionMaker();
        }

        

    }
}
