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
        public static int GenerateNumber()
        {
            return random.Next(0, 999999);
        }
        public static DateTime GenerateDate()
        {
            int randomDay = random.Next(0, 31);
            int randomMonth = random.Next(0, 13);
            int randomYear = random.Next(2019, 2025);
            int[] ar = { randomYear, randomMonth, randomDay};
            string date = string.Join(".", ar);
            DateTime dateTime = DateTime.Parse(date);
            return dateTime;
        }
        
    }
}
