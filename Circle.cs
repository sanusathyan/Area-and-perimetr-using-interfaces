using System;
using System.Collections.Generic;
using System.Text;

namespace areaPerimeter
{
    class Circle : IGeometry
    {
        private float radius;
        public void GetRadius()
        {
            Console.WriteLine("Enter the radius :");
            radius = float.Parse(Console.ReadLine());
        }
        public void FindArea()
        {
            Console.WriteLine("Area is :"+3.14 * radius * radius);
        }

        public void FindPerimeter()
        {
            Console.WriteLine("Perimeter is :" + 2 *3.14* radius);
        }
    }
}
