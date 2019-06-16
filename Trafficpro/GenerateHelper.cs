using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficpro
{
   public static class GenerateHelper
    {
        public static Random random;
        static GenerateHelper()
        {
            random = new Random();
        }
        public static int GenerateDriverNumber()
        {
            return random.Next(111111, 999999);
        }
        public static string GenerateCarNumber()
        {
            string[] series = { "AB", "LJ", "BD", "CE", "MN" };
            string randomSeries = series[random.Next(0, 4)];
            int randomNumber1 = random.Next(11, 99);
            int randomNumber2 = random.Next(111, 999);
            string result = randomNumber1.ToString() + "-" + randomSeries + "-" + randomNumber2;
            return result; 
        }
        public static DateTime GenerateExpireDate()
        {
            int randomDay = random.Next(1, 28);
            int randomMonth = random.Next(1, 12);
            int randomYear = random.Next(2019, 2025);
            int[] ar = { randomYear, randomMonth, randomDay};
            string date = string.Join(".", ar);
            DateTime dateTime = DateTime.Parse(date);
            return dateTime;
        }
        public static int GenerateSpeed()
        {
            return random.Next(70, 180);
        }
        public static int GenerateProtocolNumber()
        {
            return random.Next(11111111, 99999999) + 1;
        }
    }
}
