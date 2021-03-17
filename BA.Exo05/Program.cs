using System;

namespace BA.Exo05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez introduire le code BBAN sans tiret :");
            string bban_full = Console.ReadLine();
            string ten_first = bban_full.Substring(0, 10);
            string two_last = bban_full.Substring(10, 2);
            long ten_number = long.Parse(ten_first);
            short two_number = short.Parse(two_last);
            if ((ten_number % 97 == two_number) || ((ten_number % 97 == 0) && (two_number == 97))) Console.WriteLine("OK");
            else Console.WriteLine("KO");
        }
    }
}
