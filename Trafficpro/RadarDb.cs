using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficpro
{
    public static class RadarDb
    {
        public static DbSet<Driver> PenaltyDrivers { get; set; }
        static RadarDb()
        {
            PenaltyDrivers = new DbSet<Driver>();
        }
    }
}
