using System;

namespace BA.Exo11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 200 ; i++)
            {
                Console.WriteLine($"{i/10.0}");
            }

            for (decimal i = 0; i <= 20; i += 0.1M)
            {
                Console.WriteLine($"{i}");
            }

            for (double i = 0; i < 20.1; i += 0.1)
            {
                Console.WriteLine($"{string.Format("{0:0.0}", i)}");
            }
        }
    }
}
