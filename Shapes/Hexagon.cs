using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Hexagon : Shape
    {
        private double side;

        public Hexagon(double side=1)
        {
            this.side = side;
        }
        public override double GetArea()
        {
            return 3 * Math.Sqrt(3) * side * side / 2;
        }

        public override double GetPerimeter()
        {
            return 6 * side;
        }
    }
}
