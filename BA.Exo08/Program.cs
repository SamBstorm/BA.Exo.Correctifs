using System;

namespace BA.Exo08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez indiquer un nombre à mettre en factoriel :");
            int result = int.Parse(Console.ReadLine());
            int i = result;
            while (i > 1)
            {
                result = result * (i-1);
                i--;
            }
            Console.WriteLine(result);
        }
    }
}
