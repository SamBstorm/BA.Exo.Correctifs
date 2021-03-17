using System;

namespace BA.Exo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez entrer un premier nombre :");
            if (int.TryParse(Console.ReadLine(), out int nb1))
            {
                Console.WriteLine("Veuillez entrer un second nombre :");
                if(int.TryParse(Console.ReadLine(), out int nb2))
                {
                    Console.WriteLine($"Division entière: {nb1 / nb2} ; Modulo : {nb1 % nb2} ; Division : {(double)nb1 / nb2}");
                }
            }
        }
    }
}
