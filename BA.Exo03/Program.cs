using System;

namespace BA.Exo03
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number, moitie;
            //Console.Clear();
            //Console.WriteLine("Veuillez introduire un nombre : ");
            //string userInput = Console.ReadLine();
            //bool numberIsOk = int.TryParse(userInput, out number);
            //Console.Clear();
            //if (numberIsOk)
            //{
            //    //Test de parité
            //    moitie = number / 2;
            //    if (moitie * 2 == number) Console.WriteLine($"Le nombre {number} est pair.");
            //    else Console.WriteLine($"Le nombre {number} est impair.");
            //}
            //else
            //{
            //    Console.WriteLine($"L'entrée utilisateur '{userInput}' n'est pas un nombre entier.");
            //}
            
            Console.Clear();
            Console.WriteLine("Veuillez introduire un nombre : "); 
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                
                //Test de parité
                if ((number / 2) * 2 == number) Console.WriteLine($"Le nombre {number} est pair.");
                else Console.WriteLine($"Le nombre {number} est impair.");
            }
            else Console.WriteLine($"L'entrée utilisateur n'est pas un nombre entier.");
        }
    }
}
