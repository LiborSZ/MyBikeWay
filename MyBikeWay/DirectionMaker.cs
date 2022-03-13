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
        /// Instance of LocationsDB databse
        /// </summary>
        private LocationsDB database;
        /// <summary>
        /// Instance of current date and time.
        /// </summary>
        private DateTime currentDate = DateTime.Now;
        /// <summary>
        /// Constructor inicializing the database LocationsDB
        /// </summary>
        public DirectionMaker()
        {
            database = new LocationsDB();
        }




    } 
}
