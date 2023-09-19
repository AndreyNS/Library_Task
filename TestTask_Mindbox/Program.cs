using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Mindbox;


namespace TestTask_Mindbox
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius);
            circle.Area();

            while (true)
            {
                Console.WriteLine("Введите a,b,c треугольника");

                Console.Write("a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("c: ");
                double c = Convert.ToDouble(Console.ReadLine());


                if (a + b > c && a + c > b && b + c > a)
                {
                    Triangle triangle = new Triangle(a, b, c);
                    triangle.Area();
                    break;
                }
                else
                {
                    Console.WriteLine("Треугольник невозможен \n Хотите повторить ввод? (Да)/(Любой другой набор символов)");
                    string req = Console.ReadLine();
                    if (req == "Да")
                    {
                        continue;
                    }
                    else break;
                }
            }

            Console.ReadKey();

        }
    }
}
