using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] arStr = { "AB", "BA", "DA" };
            int randomNumber = random.Next(0,3);
           for(int i=0; i<arStr.Length;i++)
            {
                Console.WriteLine(arStr[random.Next(0, 3)]);
            }
            Console.WriteLine(Value.One);
            Console.WriteLine(Value.One.ToString());
            Value[] values = (Value[])Enum.GetValues(typeof(Value));
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
