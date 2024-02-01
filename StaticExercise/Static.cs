using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FTC(double fTemp)
        {
            var celcius = (fTemp - 32) * 5 / 9;
            Console.WriteLine(celcius);
            return celcius;
        }

        public static double CTF(double cTemp)
        {
            var fahrenheit = (cTemp * 9 / 5 + 32);
            Console.WriteLine(fahrenheit);
            return fahrenheit;
        }
    }
}
