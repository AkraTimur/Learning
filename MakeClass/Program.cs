using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace MakeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var city = new City();
			city.Name = "Kazan";
			city.Location = new GeoLocation();
			city.Location.Latitude = 55.83;
			city.Location.Longitude = 49.06;
			Console.WriteLine("I love {0} located at ({1}, {2})",
				city.Name,
				city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
				city.Location.Latitude.ToString(CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
    }
}
