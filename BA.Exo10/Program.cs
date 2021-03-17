using System;

namespace BA.Exo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Console.Write($"{j} X {i} = {i*j};\t");
                }
                Console.WriteLine();
            }
        }
    }
}
