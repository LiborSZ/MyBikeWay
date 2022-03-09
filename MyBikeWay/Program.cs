using System;

namespace MyBikeWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loc = new LocationsDB();
            loc.AddLoaction("Ořechov", 5);
            loc.AddLoaction("zele", 2);
            Console.WriteLine(loc.FindLocation("zele"));
            loc.DeleteLocation("zele");
            Console.WriteLine(loc.FindLocation("zele"));
            loc.AddLoaction("zele", 2);
            Console.WriteLine(loc.FindLocation("zele"));
            loc.DeleteLocation("Ořechov");
            loc.FindLocation("Ořechov");
        }
    }
}
