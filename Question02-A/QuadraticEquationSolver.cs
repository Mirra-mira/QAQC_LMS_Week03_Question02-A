using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class QuadraticEquationSolver
{
    public static string SolveQuadratic(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
                return c == 0 ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm";

            return $"Phương trình có 1 nghiệm: x = {-c / b}";
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
            return "Phương trình vô nghiệm";
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return $"Phương trình có nghiệm kép: x1 = x2 = {x}";
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return $"Phương trình có 2 nghiệm:\nx1 = {x1}\nx2 = {x2}";
        }
    }
}