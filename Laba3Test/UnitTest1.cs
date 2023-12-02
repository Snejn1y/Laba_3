using NUnit.Framework;
using Laba_3;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Laba3Test
{
    [TestFixture]
    public class QuadrilateralTests
    {
        [Test]
        public void RectangleArea_CorrectlyCalculated()
        {
            var rectangle = new Rectangle(10, 5);
            double expectedArea = 50;
            Assert.AreEqual(expectedArea, rectangle.CalculateArea());
        }

        [Test]
        public void SquareArea_CorrectlyCalculated()
        {
            var square = new Square(4);
            double expectedArea = 16;
            Assert.AreEqual(expectedArea, square.CalculateArea());
        }

        [Test]
        public void FindMaxAreaShape_ReturnsShapeWithMaxArea()
        {
            var shapes = new Quadrilateral[]
            {
                new Rectangle(10, 5),
                new Square(4),
                new Rectangle(3, 2),
                new Square(6),
                new Rectangle(2, 3)
            };

            var maxAreaShape = MainWindow.FindMaxAreaShape(shapes);
            Assert.IsInstanceOf<Rectangle>(maxAreaShape);
            Assert.AreEqual(50, maxAreaShape.CalculateArea());
        }
    }
}