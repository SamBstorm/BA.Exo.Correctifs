using System;

namespace BA.Exo18
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationSecondDegre eq;
            eq.A = 4;
            eq.B = 4;
            eq.C = 1;
            double? X1;
            if(eq.Resoudre(out X1, out double? X2))
            {
                Console.WriteLine("Equation possible");
                if(X2 is null)
                {
                    Console.WriteLine($"Une solution trouvée : {X1}");
                }
                else
                {
                    Console.WriteLine($"Deux solutions trouvées : {X1} et {X2}");
                }
            }
            else
            {
                Console.WriteLine("Equation impossible");
            }


        }
    }
}
