using System;

namespace BA.Exo06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez introduire le numéro de compte BBAN :");
            string bban = Console.ReadLine();
            string two_last = bban.Substring(10, 2);
            string code_temp = two_last + two_last + "111400";
            long code_number = long.Parse(code_temp);
            short two_unknows = (short)(98 - (short)(code_number % 97));
            Console.Clear();
            Console.WriteLine($"Le BBAN : {bban} ; à pour IBAN : BE{two_unknows}{bban}");
        }
    }
}
