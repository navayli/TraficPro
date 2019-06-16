using System;

namespace Testing
{
    class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GenerateDate());
        }
        public static DateTime GenerateDate()
        {
            random = new Random();
            int randomDay = random.Next(0, 31);
            int randomMonth = random.Next(0, 13);
            int randomYear = random.Next(2019, 2025);
            int[] ar = { randomYear, randomMonth, randomDay };
            string date = string.Join(".", ar);
            DateTime dateTime = DateTime.Parse(date);
            return dateTime;
        }
    }
}
