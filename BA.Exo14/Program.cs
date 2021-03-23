using System;
using System.Collections.Generic;

namespace BA.Exo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez indiquer le nombre de nombre premier que vous voulez afficher :");
            int nbSouhaite = int.Parse(Console.ReadLine());
            List<int> premiers = new List<int>();

            for (int nbAnalyse = 2; premiers.Count < nbSouhaite; nbAnalyse++)
            {
                bool isNbPremier = true;
                for (int index = 0; index < premiers.Count && premiers[index] < (nbAnalyse / 2) + 1 && isNbPremier; index++)
                {
                    if (nbAnalyse % premiers[index] == 0) isNbPremier = false;
                }
                if (isNbPremier)
                {
                    premiers.Add(nbAnalyse);
                }
            }
            foreach (int premier in premiers)
            {
                Console.WriteLine(premier);
            }
        }
    }
}

