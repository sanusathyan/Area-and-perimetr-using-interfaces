using System;

namespace areaPerimeter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Circle = new Circle();
            Circle.GetRadius();
            Circle.FindArea();
            Circle.FindPerimeter();

            var Square = new Square();
            Square.GetLength();
            Square.FindArea();
            Square.FindPerimeter();

            var Rectangle = new Rectangle();
            Rectangle.GetRectangle();
            Rectangle.FindArea();
            Rectangle.FindPerimeter();
        }
    }
}
