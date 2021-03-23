using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo17
{
    public static class CustomConvert
    {
        public static Celcius ToCelcius(double tempFahrenheit)
        {
            Celcius c;
            c.Temperature = (tempFahrenheit - 32) * (5 / 9);
            return c;
        }

        public static Celcius ToCelcius(Fahrenheit f)
        {
            return CustomConvert.ToCelcius(f.Temperature);
        }
    }
}
