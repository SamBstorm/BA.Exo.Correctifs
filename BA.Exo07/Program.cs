using System;

namespace BA.Exo07
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb0 = 0, nb1 = 1, temp, i;
            Console.Write($"{nb0}");
            i = 1;
            while (i < 25)
            {
                Console.Write($", {nb1}");
                temp = nb0 + nb1;
                nb0 = nb1;
                nb1 = temp;
                i++;
            }
        }
    }
}
