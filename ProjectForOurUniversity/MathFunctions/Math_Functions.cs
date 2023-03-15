using System;
using System.Numerics;

namespace MathFunctions
{
    public class Math_Functions
    {
        public static double BisectionMethod(Func<double, double> Function, double a, double b, double Eps)
        {

            double c = a;
            while ((b - a) >= Eps)
            {
                c = (a + b) / 2;
                if (Function(c) == 0)
                {
                    break;
                }
                else if (Function(c) * Function(a) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }
            return c;
        }
        public static double FindDerivateInPoint(double x, uint k, double Eps, Func<double, double> Function)
        {
            double x1 = x - Eps;
            double x2 = x + Eps;
            if (k == 1)
            {
                double y1 = Function(x1);
                double y2 = Function(x2);

                return (y2 - y1) / (x2 - x1);
            }
            else
            {
                double y1 = FindDerivateInPoint(x1, k - 1, Eps, Function);
                double y2 = FindDerivateInPoint(x2, k - 1, Eps, Function);

                return (y2 - y1) / (x2 - x1);
            }

        }


    }
}