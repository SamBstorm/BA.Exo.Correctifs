using System;

namespace BA.Exo.Bonus02
{
    class Program
    {
        static void Main(string[] args)
        {
            double nb1, nb2, rest;
            int result;
            Console.Clear();
            Console.WriteLine("Veuillez introduire un nombre à diviser :");
            nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez introduire un nombre diviseur :");
            nb2 = double.Parse(Console.ReadLine());
            result = (int)(nb1 / nb2);
            rest = nb1 - (result*nb2);
            Console.Clear();
            Console.WriteLine($"Le quotient de la division {nb1}/{nb2} est {result}\net le reste sera {rest}.");
        }
    }
}
