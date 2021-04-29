using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        // F i e l d s
        private string color;

        // C o n s t r u c t o r s
        public Shape()
        {
            color = "black";
        }
        

        //M e t h o d s
        public void SetColor(string color)
        {
            if (color != null && color != "")
            {
                this.color = color;
            }
        }

        public string GetColor() => color;

        public abstract double GetPerimeter();
        public abstract double GetArea();
    }
}
