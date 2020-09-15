using System;
using System.Collections.Generic;
using System.Text;

namespace hinh
{
    class Circle : Shape
    {
        public double radius;

        public override double Area()
        {
            return Math.PI * radius * radius;

        }
        public override double perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public void GetRadius()
        {
            Console.WriteLine("Radius:{0}", radius);
        }
        public Circle(string Point, double radius)
        {
            this.Point = Point;
            this.radius = radius;
        }
        public Circle() 
        {
        
        }
      
    }
}
