using System;

namespace BA.Exo02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Addition avec la conversion Parse()");
            Console.WriteLine("Veuillez introduire un premier nombre :");
            string reponse_1 = Console.ReadLine();
            int nombre_1 = int.Parse(reponse_1);
            Console.WriteLine("Veuillez introduire un second nombre :");
            int nombre_2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{nombre_1} + {nombre_2} = {nombre_1+nombre_2}");

            Console.ReadLine();


            Console.Clear();
            int number_1, number_2;
            Console.WriteLine("Addition avec la conversion TryParse()");
            Console.WriteLine("Veuillez introduire un premier nombre :");
            string answer_1 = Console.ReadLine();
            Console.WriteLine("Veuillez introduire un second nombre :");
            string answer_2 = Console.ReadLine();
            bool b_nb_1 = int.TryParse(answer_1, out number_1);
            int.TryParse(answer_2, out number_2);
            Console.Clear();
            Console.WriteLine($"{number_1} + {number_2} = {number_1 + number_2}");


        }
    }
}
