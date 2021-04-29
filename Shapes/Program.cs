using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle
            Rectangle rect1 = new Rectangle("Blue", 3, 5);
            Console.WriteLine("\nrect1 Area: " + rect1.GetArea());
            Console.WriteLine("rect1 Perimeter: " + rect1.GetPerimeter());
            Console.WriteLine("rect1 Length: " + rect1.GetLength());
            rect1.SetColor("Magenta");
            Console.WriteLine(rect1.GetColor());
            rect1.SetWidth(5);

            // Circle
            Circle circ1 = new Circle("Red", 4);
            Console.WriteLine("\ncirc1 Area: " + circ1.GetArea());
            Console.WriteLine("circ1 Circumference: " + circ1.GetPerimeter());
            Console.WriteLine("circ1 Radius: " + circ1.GetRadius());
            circ1.SetColor("Lime Green");
            Console.WriteLine(circ1.GetColor());
            circ1.SetRadius(8);

            // Square
            Square sqr1 = new Square("White", 2);
            Console.WriteLine("\nsqr1 Area: " + sqr1.GetArea());
            Console.WriteLine("sqr1 Perimeter: " + sqr1.GetPerimeter());
            Console.WriteLine("sqr1 Side: " + sqr1.GetSide());
            sqr1.SetColor("Cyan");
            Console.WriteLine(sqr1.GetColor());
            sqr1.SetSide(5);

            // Triangle
            Triangle tri1 = new Triangle("Black", 3, 5, 7);
            Console.WriteLine("\ntri1 Area: " + tri1.GetArea());
            Console.WriteLine("tri1 Perimeter: " + tri1.GetPerimeter());
            Console.WriteLine("tri1 SideA: " + tri1.GetSideA());
            tri1.SetColor("Lilac");
            Console.WriteLine(tri1.GetColor());
            tri1.SetSideC(5);

            // Hexagon
            Hexagon hex1 = new Hexagon(2);
            Console.WriteLine("\nhex1 Area: " + hex1.GetArea());
            Console.Write("hex1 Perimeter: " + hex1.GetPerimeter());
        }
    }
}
