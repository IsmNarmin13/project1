using System;

namespace MathFunctions
{
    public class Math_Functions
    {
        public static double BisectionMethod(Func<double, double> Equation, double a, double b, double Eps)
        {
            double aValue = a;
            double bValue = b;
            if (aValue * bValue > 0)
            {
                throw new Exception("Initial approximation error");
            }
            double cValue; 
            while (true)
            {
                double c = (a + b) / 2; // c - середина отрезка
                aValue = Equation(a);
                bValue = Equation(b);
                cValue = Equation(c);
                if (Math.Abs(cValue) < Eps)
                {
                    return c;
                }
                if (aValue * cValue < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }
        }

    }
}