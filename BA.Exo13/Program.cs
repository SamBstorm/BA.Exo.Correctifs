using System;
using System.Collections;

namespace BA.Exo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez introduire un nombre que les nombres ne peuvent dépasser :");
            int maxValue = int.Parse(Console.ReadLine());
            Queue queue = new Queue();
            int value = 2;
            while (value < maxValue)
            {
                bool isNbPremier = true;
                int diviseur = 2;
                while (diviseur < (value/2)+1 && isNbPremier)
                {
                    if (value % diviseur == 0) isNbPremier = false;
                    diviseur++;
                }
                if (isNbPremier)
                {
                    queue.Enqueue(value);
                }
                value++;
            }
            foreach (int nbPremier in queue)
            {
                Console.WriteLine(nbPremier);
            }

        }
    }
}
