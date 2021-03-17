using System;

namespace BA.Exo.Bonus.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double ab, ac, bc;
            Console.Clear();
            Console.WriteLine("Veuillez introduire la distance entre le sommet A et le sommet B :");
            if(double.TryParse(Console.ReadLine(), out ab) && ab != 0)
            {
                Console.WriteLine("Veuillez introduire la distance entre le sommet B et le sommet C :");
                if (double.TryParse(Console.ReadLine(), out bc) && bc != 0)
                {
                    Console.WriteLine("Veuillez introduire la distance entre le sommet A et le sommet C :");
                    if (double.TryParse(Console.ReadLine(), out ac) && ac != 0)
                    {
                        if (ab < 0)
                        {
                            ab *= -1;
                        }
                        if (bc < 0)
                        {
                            bc *= -1;
                        }
                        if (ac < 0)
                        {
                            ac *= -1;
                        }
                        if(ab == bc && ab == ac)
                        {
                            Console.WriteLine("Triangle équilatéral accutangle");
                        }
                        else
                        {
                            if (ab < bc)
                            {
                                ab = ab + bc;
                                bc = ab - bc;
                                ab = ab - bc;
                            }
                            if (ab < ac)
                            {
                                ab = ab + ac;
                                ac = ab - ac;
                                ab = ab - ac;
                            }
                            if (ab >= ac + bc)
                            {
                                Console.WriteLine("Triangle impossible");
                            }
                            else
                            {
                                if (ab == ac || ab == bc || ac == bc)
                                {
                                    Console.Write("Triangle isocèle ");
                                }
                                else
                                {
                                    Console.Write("Triangle scalène ");
                                }
                                if (ab*ab == (ac*ac)+(bc*bc))
                                {
                                    Console.WriteLine("rectangle");
                                }
                                else if (ab * ab > (ac * ac) + (bc * bc))
                                {
                                    Console.WriteLine("obtusangle");
                                }
                                else
                                {
                                    Console.WriteLine("accutangle");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Distance AC incorrecte.");
                    }
                }
                else
                {
                    Console.WriteLine("Distance BC incorrecte.");
                }
            }
            else
            {
                Console.WriteLine("Distance AB incorrecte.");
            }
        }
    }
}
