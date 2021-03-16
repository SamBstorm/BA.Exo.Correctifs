using System;

namespace BA.Exo.Bonus01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un caractère :");
            char c = Convert.ToChar(Console.ReadLine());
            ushort ascii = c;
            Console.WriteLine($"Le caractère {c} a pour code : {ascii}");
        }
    }
}
