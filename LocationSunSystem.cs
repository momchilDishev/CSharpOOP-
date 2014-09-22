using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    public enum Planet
    {
        Earth, Mars, Venus, Mercury
    }

    public struct Location
    {
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public Planet Planet { get; set; }


        public Location(double latitude, double longtitude, Planet Planet)
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.Planet = Planet;
        }
         public override string ToString()
         {
             return this.Latitude + ", " +
                 this.Longtitude + ", " +
                 this.Planet;
         }

    }


}

namespace ConsoleApplication19
{
    class TestLocations
    {
        static void Main()
        {
            Location sofia = new Location(4.7, 23.33, Planet.Earth);
            Console.WriteLine(sofia);
        }
     
    }
    
}
