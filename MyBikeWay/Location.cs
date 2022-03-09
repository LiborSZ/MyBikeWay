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
        public string Name { get; private set; }
        /// <summary>
        /// Coordinate X in decimal degrees (format xx.xxxxx)
        /// </summary>
        public double CoordinateX { get; private set; }
        /// <summary>
        /// Coordinate Y in decimal degrees (format yy.yyyyyy)
        /// </summary>
        public double CoordinateY { get; private set; }
        /// <summary>
        /// Distance in Km from default point
        /// </summary>
        public double StartingPointDistance { get; private set; }
        /// <summary>
        /// Constructor with properties inicialization
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="CoordinateX"></param>
        /// <param name="CoordinateY"></param>
        /// <param name="StartingPointDistance"></param>
        public Location(string name, double coordinateX, double coordinateY, double distance)
        {
            Name = name;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            StartingPointDistance = distance;
        }
        /// <summary>
        /// Returns name and distance from default point as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{Name} je vzdálený od výchozí lokace o {StartingPointDistance} km");
        }
    }
}
