using System;

namespace BA.Exo09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Veuillez indiquer le nombre de nombre premier que vous voulez afficher :");
            int nbSouhaite = int.Parse(Console.ReadLine());
            int nbTrouve = 0;
            for (int nbAnalyse = 1; nbTrouve < nbSouhaite; nbAnalyse++)
            {
                bool isNbPremier = true;
                int nbDiv = 0;
                for(int diviseur = 1; diviseur < nbAnalyse; diviseur++)
                {
                    if (nbAnalyse % diviseur == 0) nbDiv++;
                }
                isNbPremier = nbDiv == 2;
                if (isNbPremier)
                {
                    nbTrouve++;
                    Console.WriteLine(nbAnalyse);
                }
            }

            //for (int nbAnalyse = 2; nbTrouve < nbSouhaite; nbAnalyse++)
            //{
            //    bool isNbPremier = true;
            //    for (int diviseur = 2; diviseur < (nbAnalyse / 2) + 1 && isNbPremier; diviseur++)
            //    {
            //        if (nbAnalyse % diviseur == 0) isNbPremier = false;
            //    }
            //    if (isNbPremier)
            //    {
            //        nbTrouve++;
            //        Console.WriteLine(nbAnalyse);
            //    }
            //}
        }
    }
}
