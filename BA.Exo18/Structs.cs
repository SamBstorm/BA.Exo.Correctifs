using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo18
{
    public struct EquationSecondDegre
    {
        public double A, B, C;

        public bool Resoudre(out double? x1, out double? x2)
        {
            x1 = null;          //x1 = x2 = null;
            x2 = null;
            double delta = GetDelta();                  //double delta = (B * B) - (4 * A * C);
            if (delta < 0) return false;
            else if (delta == 0)
            {
                x1 = GetFinalResult();             // x1 = -B / (2 * A);
            }
            else
            {
                x1 = GetFinalResult(-Math.Sqrt(delta)); //x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                x2 = GetFinalResult(Math.Sqrt(delta));  //x2 = (-B + Math.Sqrt(delta)) / (2 * A);
            }
            return true;
            /*
             else 
            {
                x1 = GetFinalResult(-Math.Sqrt(delta));//-B / (2 * A);
                if (delta > 0)
                {
                    x2 = GetFinalResult(Math.Sqrt(delta));
                }
            }            
            return true;
             */
        }

        public double GetDelta()
        {
            return (B * B) - (4 * A * C);
        }

        public double GetFinalResult(double sqrtDelta = 0)
        {
            return (-B + sqrtDelta) / (2 * A);
        }
    }
}
