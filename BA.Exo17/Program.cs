using System;

namespace BA.Exo17
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius c;
            c.Temperature = 0;
            Console.WriteLine($"{c.ToFahrenheit()}°F");
            c = CustomConvert.ToCelcius(new Fahrenheit { Temperature = 13 });
            Console.WriteLine($"{c.Temperature}°C");
        }

    }
    public struct Celcius
    {
        public double Temperature;

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit f;
            f.Temperature = (Temperature * (9 / 5)) + 32 ;
            return f;
        }
        public Fahrenheit ToFahrenheit(Celcius c)
        {
            Fahrenheit f;
            f.Temperature = (c.Temperature * (9 / 5)) + 32;
            return f;
        }
        public Fahrenheit ToFahrenheit(double tempCelcius)
        {
            Fahrenheit f;
            f.Temperature = (tempCelcius * (9 / 5)) + 32;
            return f;
        }
    }

    public struct Fahrenheit
    {
        public double Temperature;

        public Celcius ToCelcius()
        {
            return ToCelcius(Temperature);      //On se simplifie la tâche:
                                                //vu qu'une méthode fait déjà la conversion,
                                                //on l'utilise pour obtenir le comportement souhaité
                                                //sur la valeur concernée.
        }

        public Celcius ToCelcius(Fahrenheit f)
        {
            return ToCelcius(f.Temperature);    //On se simplifie la tâche:
                                                //vu qu'une méthode fait déjà la conversion,
                                                //on l'utilise pour obtenir le comportement souhaité
                                                //sur la valeur concernée.
        }

        public Celcius ToCelcius(double tempFahrenheit)
        {
            Celcius c;
            c.Temperature = (tempFahrenheit - 32) * (5 / 9);
            return c;
        }
    }
}
