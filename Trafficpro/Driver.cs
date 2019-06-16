using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficpro
{
   public class Driver
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DriverGender DriverGender { get; set; }
        public DateTime LicenseExpireDate { get; set; }

        [Penalty(10)]
        public PenaltyBallType PenaltyQuota { get; set; }
        public int LicenseNumber { get; set; }
        public string CarNumber { get; set; }
        public int Speed { get; set; }    
    }
}
