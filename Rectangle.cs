using System;
using System.Collections.Generic;
using System.Text;

namespace areaPerimeter
{
    class Rectangle : IGeometry
    {
        private int lengthRectangle;
        private int breadthRectangle;

        public void GetRectangle()
        {
            Console.WriteLine("Enter the length :");
            lengthRectangle = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth :");
            breadthRectangle = int.Parse(Console.ReadLine());

        }
        public void FindArea()
        {
            Console.WriteLine("The area is : " + lengthRectangle * breadthRectangle);
        }

        public void FindPerimeter()
        {
            Console.WriteLine("The perimeter is : " + 2 * ( lengthRectangle + breadthRectangle ));
        }
    }
}
