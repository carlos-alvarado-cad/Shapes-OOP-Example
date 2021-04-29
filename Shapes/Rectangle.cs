using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        // F i e l d s
        private double width, length;

        // C o n s t u c t o r 
        public Rectangle(string color, double width = 1, double length = 1)
        {
            SetColor(color);
            SetWidth(width);
            SetLength(length);
        }

        // M e t h o d s
        public override double GetArea()
        {
            return width * length;
        }

        public override double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public double GetLength()
        {
            return length;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetLength(double length)
        {
            if (length < 0)
            {
                length = -length;
            }
            else if (length == 0)
            {
                length = 1;
            }
            this.length = length;
        }

        public void SetWidth(double width)
        {
            if (width < 0)
            {
                width = -width; ;
            }
            else if (width == 0)
            {
                width = 1;
            }
            this.width = width;
        }
    }
}
