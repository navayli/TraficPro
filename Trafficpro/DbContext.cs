using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficpro
{
   public static class DbContext
    {
      
        public static DbSet<Driver> Drivers { get; set; }
        static DbContext()
        {
            Drivers = new DbSet<Driver>();
            Drivers.Add(new Driver
            {
                Name = "Ali",
                Surname = "Nadjafli",
                LicenseNumber = GenerateHelper.GenerateDriverNumber(),
                LicenseExpireDate = GenerateHelper.GenerateExpireDate(),
                PenaltyQuota = PenaltyBallType.Zero,
                Speed  = GenerateHelper.GenerateSpeed(),
                CarNumber = GenerateHelper.GenerateCarNumber(),
                DriverGender = DriverGender.Male
            });
             Drivers.Add(new Driver
             {
                 Name = "Musa",
                 Surname = "Bagirov",
                 LicenseNumber = GenerateHelper.GenerateDriverNumber(),
                 LicenseExpireDate = GenerateHelper.GenerateExpireDate(),
                 PenaltyQuota = PenaltyBallType.Three,
                 Speed = GenerateHelper.GenerateSpeed(),
                 CarNumber = GenerateHelper.GenerateCarNumber(),
                 DriverGender = DriverGender.Male
             });
            Drivers.Add(new Driver
            {
                Name = "Ruqiyye",
                Surname = "Nadjafli",
                LicenseNumber = GenerateHelper.GenerateDriverNumber(),
                LicenseExpireDate = GenerateHelper.GenerateExpireDate(),
                PenaltyQuota = PenaltyBallType.One,
                Speed = GenerateHelper.GenerateSpeed(),
                CarNumber = GenerateHelper.GenerateCarNumber(),
                DriverGender = DriverGender.Female
            });
            Drivers.Add(new Driver
            {
                Name = "Nurcahan",
                Surname = "Bagirova",
                LicenseNumber = GenerateHelper.GenerateDriverNumber(),
                LicenseExpireDate = GenerateHelper.GenerateExpireDate(),
                PenaltyQuota = PenaltyBallType.Four,
                Speed = GenerateHelper.GenerateSpeed(),
                CarNumber = GenerateHelper.GenerateCarNumber(),
                DriverGender = DriverGender.Female
            });
            Drivers.Add(new Driver
            {
                Name = "Yunis",
                Surname = "Nadjafli",
                LicenseNumber = GenerateHelper.GenerateDriverNumber(),
                LicenseExpireDate = GenerateHelper.GenerateExpireDate(),
                PenaltyQuota = PenaltyBallType.Four,
                Speed = GenerateHelper.GenerateSpeed(),
                CarNumber = GenerateHelper.GenerateCarNumber(),
                DriverGender = DriverGender.Male
            });

        }

    }
}
