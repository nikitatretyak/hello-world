using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace Square
{
    public class Program
    {
        static void Main()
        {
            Square(4, 4, 1, out double x1, out double x2, out string message);
        }
        public static void Square(double a, double b, double c, out double x1, out double x2, out string message)
        {
            try
            {
                x1=0; x2=0;message = "";
                if (a == 0)
                {
                    throw new Exception();
                }

                double D = Math.Pow(b, 2) - (4 * a * c);
                if (D < 0)
                {
                    x1 = 0;
                    x2 = 0;
                    message = "Нет корней";
                }
                if (D == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = 0;
                    message = "1 корень";
                }
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    message = "2 корня";
                }
            }
            catch (Exception)
            {
                message = "Это не квадратное уравнение";
                x1 = 0;
                x2 = 0;

            }
        }
    }
}

