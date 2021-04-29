using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        // F i e l d s
        private double side;

        // C o n s t r u c t o r s
        public Square(string color, double side = 1)
        {
            SetColor(color);
            SetSide(side);
        }
        // M e t h o d s
        public void SetSide(double side)
        {
            if (side == 0)
            {
                side = 1;
            }
            else if (side < 0)
            {
                side = -side;
            }
            this.side = side;
        }

        public double GetSide() => side;

        public override double GetArea() => side * side;

        public override double GetPerimeter() => 4 * side;
    }
}
