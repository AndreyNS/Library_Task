using System;

namespace Library_Mindbox
{
    public abstract class Figure
    {
        public abstract void Area();
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double rad)
        {

            Radius = rad;
        }

        public override void Area() => Console.WriteLine(Math.PI * Radius);
    }

    public class Triangle : Figure
    {
        public double p { get; set; }
        public double S { get; set; }

        public string TriangleType { get; set; }

        public Triangle(double a, double b, double c)
        {
            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);

            if ((a2 + b2) == c2 || (a2 + c2) == b2 || (b2 + c2) == a2)
            {
                TriangleType = "Прямоугольный";
            }
            else if (a == b && b == c)
            {
                TriangleType = "Равносторонний";
            }
            else if (a == b || a == c || b == c)
            {
                TriangleType = "Равнобедренный";
            }
            else TriangleType = "Обычный";

            p = (a + b + c) / 2;

            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void Area() => Console.WriteLine($"{TriangleType} S={S}");
    }
}
