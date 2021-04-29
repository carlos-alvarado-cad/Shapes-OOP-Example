using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle : Shape
    {
        // F i e l d s
        private double sideA, sideB, sideC;

        // C o n s t r u c t o r s
        public Triangle(string color, double sideA = 1, double sideB = 1, double sideC = 1)
        {
            SetColor(color);
            SetSideA(sideA);
            SetSideB(sideB);
            SetSideC(sideC);
        }
        // M e t h o d s
        public void SetSideA(double sideA)
        {
            if (sideA < 0)
            {
                sideA = -sideA; ;
            }
            else if (sideA == 0)
            {
                sideA = 1;
            }
            this.sideA = sideA;
        }

        public void SetSideB(double sideB)
        {
            if (sideB < 0)
            {
                sideB = -sideB; ;
            }
            else if (sideB == 0)
            {
                sideB = 1;
            }
            this.sideB = sideB;
        }

        public void SetSideC(double sideC)
        {
            if (sideC < 0)
            {
                sideC = -sideC; ;
            }
            else if (sideC == 0)
            {
                sideC = 1;
            }
            this.sideC = sideC;
        }

        public double GetSideA() => sideA;

        public double GetSideB() => sideB;

        public double GetSideC() => sideC;

        public override double GetPerimeter() => sideA + sideB + sideC;

        public override double GetArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            return area;
        }

    }
}
