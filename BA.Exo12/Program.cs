using System;

namespace BA.Exo12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez indiquer le nombre à modifier :");
            int number = int.Parse(Console.ReadLine());
            int nbDecimal = 0;
            double result = 0, rest = number;
            while(nbDecimal < 11 && rest != 0)
            {
                int value = 0;
                while (number >= (Math.Pow(result + (value / Math.Pow(10, nbDecimal)),2)))
                {
                    value++;
                }
                rest = (rest*10) % (value-1);
                result = result + ((value-1) / Math.Pow(10, nbDecimal));
                nbDecimal++;
            }
            Console.WriteLine(result);
        }
    }
}
