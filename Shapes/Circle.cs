using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        // F i e l d s
        private double radius;

        // C o n s t r u c t o r s
        public Circle(string color, double radius = 1)
        {
            SetColor(color);
            SetRadius(radius);
        }

        // M e t h o d s
        public override double GetArea() => Math.PI * radius * radius;

        public override double GetPerimeter() => 2 * Math.PI * radius;

        public double GetRadius() => radius;

        public void SetRadius(double radius)
        {
            if (radius == 0)
            {
                radius = 1;
            }
            else if (radius < 0)
            {
                radius = -radius;
            }
            this.radius = radius;
        }
    }
}
