using System;
using System.Collections.Generic;

namespace Library_Mindbox
{
    public abstract class Figure
    {
        public abstract double Area();
    }

    public class Circle : Figure
    {
        public double Radius { get;}
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            Radius = radius;
        }

        public void Print() => Console.WriteLine(Math.PI * Math.Pow(Radius, 2));
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : Figure
    {

        public double SideA { get;}
        public double SideB { get; }
        public double SideC { get; }

        public string TriangleType { get;}
        public double Square { get; }

        public Triangle(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Треугольник с такими сторонами невозможно создать.");
            }

            SideA = a;
            SideB = b;
            SideC = c;

            CalculateTriangleType(out string Type);

            TriangleType = Type;

            double Sperimeter = (SideA + SideB + SideC) / 2;

            Square = Math.Sqrt(Sperimeter * (Sperimeter - SideA) * (Sperimeter - SideB) * (Sperimeter - SideC));

        }

        public void Print() => Console.WriteLine($"{TriangleType} S={Square}");

        public override double Area()
        {
            return Square;
        }


        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
            
        }

        private void CalculateTriangleType(out string Type)
        {

            if ((SideA + SideB) == SideC || (SideA + SideC) == SideB || (SideB + SideC) == SideA)
            {
                Type = "Прямоугольный";
            }
            else if (SideA == SideB && SideB == SideC)
            {
                Type = "Равносторонний";
            }
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
            {
                Type = "Равнобедренный";
            }
            else Type = "Обычный";
        }
    }
}


