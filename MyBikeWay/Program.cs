using System;

namespace MyBikeWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocationsDB loc = new LocationsDB();
            loc.AddLoaction("Orechov", 8);
            //loc.AddLoaction("Zele", 4);
            loc.AddLoaction("Orechov", 45.1111,33.5658,8);
            loc.AddLoaction("Zele", 45.788,56.777,4);
            loc.AddLoaction("Zele", 45.788, 56.777, 5);

            loc.UpdateLocationDistance("Zele", 44);

            Console.WriteLine(loc.FindLocation("Zele"));
            
        }
    }
}
