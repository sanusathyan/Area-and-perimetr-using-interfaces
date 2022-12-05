using System;
using System.Collections.Generic;
using System.Text;

namespace areaPerimeter
{
    class Square : IGeometry
    {
        private int length;

        public void GetLength()
        {
            Console.WriteLine("Enter the length :");
            length = int.Parse(Console.ReadLine());
        }
        public void FindArea()
        {
            Console.WriteLine("The area is : "+length*length);
        }

        public void FindPerimeter()
        {
            Console.WriteLine("The perimeter is : " + 4 * length);
        }
    }
}
