using System;

namespace MyBikeWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dir = new DirectionMaker();
            dir.AddLocationWithoutCoordinates();
            dir.AddExistingLocation();
            dir.AddExistingLocation();
            dir.WriteDirection();
        }
    }
}
