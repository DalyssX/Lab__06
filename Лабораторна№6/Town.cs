using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_6
{
    public class TheTown
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string BikeType { get; set; }
        public string SuspensionType { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public bool HasHydraulicBrakes { get; set; }
        public bool HasHydraulicSeatPot { get; set; }
        
        public TheTown()
        {
        }
        public TheTown(string name, string country, string region,
        string suspension, double yearIncome, double square,
        bool hasPort, bool hasAirport)
        {
            Name = name;
            Country = country;
            BikeType = region;
            SuspensionType = suspension;
            Weight = yearIncome;
            Price = square;
            HasHydraulicBrakes = hasPort;
            HasHydraulicSeatPot = hasAirport;
        }
    }
}
