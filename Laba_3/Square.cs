using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
    class Square : Quadrilateral
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
            figura = "Square";
        }

        public override double CalculateArea() => Side * Side;

        public override string Print() => $"Figura = {figura}, side = {Side}";
    }
}
