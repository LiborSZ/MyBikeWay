using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeWay
{
    internal class Location
    {
        /// <summary>
        /// Location name (city or village etc.)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Coordinate X in decimal degrees (format xx.xxxxx)
        /// </summary>
        public double CoordinateX { get;  set; }
        /// <summary>
        /// Coordinate Y in decimal degrees (format yy.yyyyyy)
        /// </summary>
        public double CoordinateY { get;  set; }
        /// <summary>
        /// Distance in Km from previous point
        /// </summary>
        public double PreviousPointDistance { get;  set; }
        /// <summary>
        /// Constructor with properties inicialization
        /// </summary>
        /// <param name="Name">Location name</param>
        /// <param name="CoordinateX">Coordinate X</param>
        /// <param name="CoordinateY">Coordinate Y</param>
        /// <param name="StartingPointDistance">Distance from previous point</param>
        public Location(string name, double coordinateX, double coordinateY, double distance)
        {
            Name = name;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            PreviousPointDistance = distance;
        }
        /// <summary>
        /// Constructor overload for name and distance only
        /// </summary>
        /// <param name="name">Location name</param>
        /// <param name="distance">Distance from defualt point</param>
        public Location(string name, double distance)
        {
            Name = name;
            PreviousPointDistance = distance;
        }
        /// <summary>
        /// Returns name and distance from previous point as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{Name} is {PreviousPointDistance} km away from the location");
        }
    }
}
