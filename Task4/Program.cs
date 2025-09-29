﻿namespace Task4
{
    public class Program
    {
        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "рівносторонній";
            }
            if (a == b || a == c || b == c)
            {
                return "рівнобедрений";
            }

            if (a * a + b * b == c * c ||
           a * a + c * c == b * b ||
           b * b + c * c == a * a)
                return "прямокутний";

            return "довільний";
        }

        public static void Main()
        {
            Console.Write("Введіть сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (!IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Трикутник не існує");
                return;
            }

            Console.WriteLine($"Периметр: {GetPerimeter(a, b, c)}");
            Console.WriteLine($"Площа:  {GetArea(a, b, c)}");
            Console.WriteLine($"Тип: {GetTriangleType(a, b, c)}");
        }
    }

}
