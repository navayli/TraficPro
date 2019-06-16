using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficpro
{
    public static class ExtensionHelper
    {
        public static Driver FindDriverByNumber(this DbSet<Driver> drivers, int number)
        {
            Driver driver = null;
            foreach(Driver dr in drivers.GetAll())
            {
                if (dr.LicenseNumber == number)
                {
                    driver = dr;
                    break;
                }
            }
            return driver;
        }
    }
}
