using System;
using System.Text;
public class QuadraticEquationSolver
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Nhập hệ số a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập hệ số b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập hệ số c:");
        double c = Convert.ToDouble(Console.ReadLine());
        string result = Solve(a, b, c);
        Console.WriteLine(result);
    }
    // Phương trình: ax^2 + bx + c = 0
    public static string Solve(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
                return (c == 0) ? "Vô số nghiệm" : "Vô nghiệm";

            double x = -c / b;
            return $"1 nghiệm: x = {x}";
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return "Vô nghiệm";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            return $"Nghiệm kép: x1 = x2 = {x}";
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return $"2 nghiệm: x1 = {x1}, x2 = {x2}";
        }
    }
}
