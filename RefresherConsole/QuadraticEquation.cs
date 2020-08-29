using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    public class QuadraticEquation
    {
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            double d, x1, x2;

            //Tuple<double, double> roots = new Tuple<double, double>(1,1);

            d = b * b - 4 * a * c;
            if (d == 0) //both roots are equal
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }

            var roots = Tuple.Create(x1, x2);
            return roots;
            //throw new NotImplementedException("Waiting to be implemented.");
        }       
    }






}
