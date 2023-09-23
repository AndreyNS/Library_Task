using NUnit.Framework;
using Library_Mindbox; 

namespace TestTask_MindboxUnit
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestCircleArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            
            double area = circle.Area();

            Assert.AreEqual(78.5398163, area, 0.000001);

        }

        [Test]
        public void TestTriangleArea()
        {
            
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            
            double area = triangle.Area();

            Assert.AreEqual(6, area, 0.000001);

        }
    }
}
