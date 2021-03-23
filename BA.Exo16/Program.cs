using System;

namespace BA.Exo16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 5;
            Point?[,] tableau = new Point?[TAILLE, TAILLE];

            for (int i = 0; i < TAILLE; i++)
            {
                Point p;
                p.X = i + 1;
                p.Y = i + 1;
                tableau[i, i] = p;
            }

            for (int x = 0; x < TAILLE; x++)
            {
                for (int y = 0; y < TAILLE; y++)
                {
                    if (tableau[x, y] is null) Console.Write('\t');
                    else Console.Write($"X : {((Point)tableau[x,y]).X} - Y : {((Point)tableau[x, y]).Y}");
                }
                Console.WriteLine();
            }
        }
    }
}
