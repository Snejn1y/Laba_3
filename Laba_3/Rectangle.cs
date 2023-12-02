using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    public class Rectangle : Quadrilateral
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            figura = "Rectangle";
        }

        public override double CalculateArea() => Length * Width;

        public override string Print() => $"Figura = {figura}, length = {Length}, width = {Width}";
    }
}
